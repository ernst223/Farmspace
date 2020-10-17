import { Component, OnInit, ViewChild } from '@angular/core';
import { MatSnackBar, MatTableDataSource, MatSort, MatPaginator, MatDialog } from '@angular/material';
import { SharedService } from 'app/shared/shared.service';
import { EntryForDisplayDto, DeleteByIdDto } from 'app/shared/shared.models';
import { Router } from '@angular/router';
import { DeleteDialogComponent } from 'app/delete-dialog/delete-dialog.component';

@Component({
  selector: 'app-upload-products',
  templateUrl: './upload-products.component.html',
  styleUrls: ['./upload-products.component.scss']
})
export class UploadProductsComponent implements OnInit {
  uploadFileLabel = 'Choose CSV file...';
  theFile: any;
  fileName = '';
  canUpload = false;
  loader = false;
  viewData = false;
  selectAll = false;
  showLatestUploads = false;
  selectedRowIndex: number = -1;
  myData: EntryForDisplayDto[];
  myLatestUploadedData: EntryForDisplayDto[];
  uploadAmount = 0;
  isDeleteing = false;
  DeleteEntriesDto: DeleteByIdDto = {id: []};
  displayHeading = '';
  orderDataSource: MatTableDataSource<object> = new MatTableDataSource();
  displayedColumns = ['Id','EntryName','BrandName','Range', 'Actions', 'Select'];
  @ViewChild(MatSort, { static: true }) sort: MatSort;
  @ViewChild(MatPaginator, { static: false }) paginator: MatPaginator;
  constructor( private _snackBar: MatSnackBar, public dialog: MatDialog, public share: SharedService, private router: Router) { }

  ngOnInit() {
    this.orderDataSource.sort = this.sort;
    this.setupDataStream();
  }
  ngAfterViewInit() {
    this.orderDataSource.sort = this.sort;
    this.orderDataSource.paginator = this.paginator;
  }

  setupDataStream(){
    // console.log('All data');
    this.displayHeading = "Latest 100 Entries";
    this.share.getEntryForDisplay().subscribe(a => {
      this.myData = a;
      this.orderDataSource.data = this.myData;
      this.viewData = true;
    });
  }

  setLatestUploadedData() {
    // console.log('Latest Uploads');
    this.displayHeading = "Uploaded Entries";
    if(this.uploadAmount == 0){
      this.openSnackBar('No Uploaded Data', 'Close');
      this .orderDataSource.data = undefined;
    }else{
      this.share.getLatestUploadEntryForDisplay(this.uploadAmount).subscribe(a => {
        this.myLatestUploadedData = a;
        this.orderDataSource.data = this.myLatestUploadedData;
        this.viewData = true;
      });
    }
  }

  myIViewThis(): boolean{
    return this.share.isInRole('Admin');
  }
  OpenFile(event: any) {
    // The file is in this event
    // console.log(event.target.files[0].name);
    this.uploadFileLabel = event.target.files[0].name;
    this.theFile = event.target.files[0];
    this.fileName = event.target.files[0].name;
    this.canUpload = true;
    this.openSnackBar('File Ready For Processing', 'Close');
  }
  openSnackBar(message: string, action: string) {
    this._snackBar.open(message, action, {
      duration: 3500,
    });
  }

  addOrRemoveFromMyDeleteList(a: any, id: number) {
    if(a.checked == true){
      this.DeleteEntriesDto.id.push(id);
    }else{
      this.DeleteEntriesDto.id.splice(this.DeleteEntriesDto.id.findIndex(item => item == id), 1);
    }
  }

  navigateToEntry(id: number) {
    this.router.navigate([]).then(result => {window.open('http://farmboek.dankospark.co.za/productsAndServices/entry/' + id) });
  }
  uploadEntry(){
    this.loader = true;
    this.canUpload = false;
    this.openSnackBar('Please wait for server', 'Close');
    this.share.uploadEntry(this.theFile).subscribe(a => {
      this.loader = false;
      // console.log(a.myString);
      this.uploadAmount = a.amountOfUploads;
      this.openSnackBar(a.myString, 'Close');
      this.clearFileUpload();
      this.showLatestUploads = true;
      this.setLatestUploadedData();
    });
  }

  ToggleSelectAll(a: any){
    if(a.checked == false){
      this.selectAll = false;
    }else{
      this.selectAll = true;;
    }
  }
  toggleSide(a: any){
    this.orderDataSource.data = undefined;
    if(a.checked == true){
      this.showLatestUploads = true;
      this.selectAll = false;
      this.setLatestUploadedData();
    }else{
      this.showLatestUploads = false;
      this.selectAll = false;
      this.setupDataStream();
    }
  }
  clearFileUpload() {
    this.canUpload = false;
    this.uploadFileLabel = 'Choose CSV file...';
    this.theFile = undefined;
  }

  delete() {
    const dialogRef = this.dialog.open(DeleteDialogComponent, {
      width: '400px'
    });

    dialogRef.afterClosed().subscribe(result => {
     if(result == true){
      if(this.selectAll == true) {
        this.DeleteEntriesDto.id = [];
          this.myLatestUploadedData.forEach(element => {
            this.DeleteEntriesDto.id.push(element.entryId);
          });
        this.deleteEntries();
      } else {
        this.deleteEntries();
      }
     }
    });
  }
  deleteEntries() {
    this.isDeleteing = true;
    this.share.deleteEntries(this.DeleteEntriesDto).subscribe(a => {
      if(a == true){
        this.openSnackBar('Entries Deleted', 'Close');
        this.uploadAmount = 0;
        this.setupDataStream();
        this.DeleteEntriesDto.id = [];
        this.selectAll = false;
        this.showLatestUploads = false;
      }else{
        this.openSnackBar('Oops Something went wrong', 'CLose');
      }
      this.isDeleteing = false;
    });
  }
}
