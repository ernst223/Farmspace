import { Component, OnInit } from '@angular/core';
import { EntryAttributesDto, BrandDto, EntryRange, MediaDto, pdfDTO } from 'app/shared/shared.models';
import { environment } from 'environments/environment';
import { ActivatedRoute, Router } from '@angular/router';
import { SharedService } from 'app/shared/shared.service';
import { MatSnackBar, MatDialog } from '@angular/material';
import { LogindialogComponent } from 'app/logindialog/logindialog.component';

@Component({
  selector: 'app-viewentryseo',
  templateUrl: './viewentryseo.component.html',
  styleUrls: ['./viewentryseo.component.scss']
})
export class ViewentryseoComponent implements OnInit {

  entryId = 0;
    showme = false;
    myAttributes: EntryAttributesDto[] = [];
    myBrand: BrandDto;
    myRanges: EntryRange[];
    heading = '';
    selectedLevel: any;
    connectionstring = environment.imageUrl;
    supergroup = '';
    group = '';
    subgroup = '';
    brand = '';
    productname = '';
    showMedia = false;
    myRelatedMedia: MediaDto[] = [];
    MediaByRange = true;
    mediaHeader = 'Related Media Posts';
    theFile: any;
  fileName: any;
  myPDFupload: pdfDTO;
    
  constructor(private route: ActivatedRoute, public dialog: MatDialog, private service: SharedService, private router: Router, private snackbar: MatSnackBar) { }

  ngOnInit() {
    let re = /\_/gi;
    this.route.params.subscribe(a => {
        this.supergroup = a.supergroup.replace(re, ' ');
        this.group = a.group.replace(re, ' ');
        this.subgroup = a.subgroup.replace(re, ' ');
        this.brand = a.brand.replace(re, ' ');
        this.productname = a.productname.replace(re, ' ');
        this.setupDataStream();
    });
  }
  getProductMediaByRangeId() {
    this.service.getMediaByProduct(this.myRanges[0].entryId).subscribe(a => {
      this.myRelatedMedia = a;
      if (this.myRelatedMedia.length == 0){
        this.mediaHeader = 'No Related Media';
      }else{
        this.mediaHeader = 'Related Media Posts';
      }
      this.showMedia = true;
    });
  }
  getProductMediaByEntryId() {
    this.service.getMediaByProduct(this.entryId).subscribe(a => {
      this.myRelatedMedia = a;
      if (this.myRelatedMedia.length == 0){
        this.mediaHeader = 'No Related Media';
      }else{
        this.mediaHeader = 'Related Media Posts';
      }
      this.showMedia = true;
    });
  }
  deletePDF() {
    if(this.entryId == 0){
      this.openSnackBar('Please select a Entry', '');
    }else{
      this.service.deleteEntryPDF(this.entryId).subscribe(a => {
        // console.log('Delete result' + a);
        this.openSnackBar('PDF deleted', '');
      });
    }
  }
  openPDFConnectionString() {
    if(this.entryId == 0){
      let url = environment.pdfURL + 'EntryPDF/' + this.myRanges[0].entryId + '.pdf';
      window.open(url);
    }else{
      let url = environment.pdfURL + 'EntryPDF/' + this.entryId + '.pdf';
      window.open(url);
    }
  }
  OpenImage(event: any) {
    // The file is in this event
    if(this.entryId == 0){
      this.entryId = +this.myRanges[0].entryId;
    }
      this.theFile = event.target.files[0];
      this.fileName = event.target.files[0].name;
      const reader = new FileReader();
      reader.readAsDataURL(this.theFile);
      let result;
      reader.onload = (e) => {
        result = reader.result;
        this.myPDFupload = {
          thePDF: result,
          thePDFName: this.entryId + '.pdf',
          id: this.entryId
        }
        this.service.postEntryPDF(this.myPDFupload).subscribe(a => {
          this.openSnackBar('uploaded', '');
        });
      }
    
  }
  openSnackBar(message: string, action: string) {
    this.snackbar.open(message, action, {
      duration: 2000,
    });
  }
  setupDataStream() {
      this.service.GetEntryAttributesByName(this.productname).subscribe(a => {
          this.myAttributes = a;
          this.heading = this.myAttributes[0].entryName;
          this.getEntryBrand();
          this.getEntriesByRange();
      });
  }
  getEntriesByRange() {
      this.service.getEntriesByRange(this.myAttributes[0].entryRange).subscribe(a => {
          this.myRanges = a;
          if(this.MediaByRange == true){
            this.MediaByRange = false;
            this.getProductMediaByRangeId();
          } else {
            this.getProductMediaByEntryId();
          }
      });
  }
  getImageConnectionString(): string {
      if(this.myAttributes[0].imageLink != undefined){
        return this.connectionstring + this.myAttributes[0].imageLink;
      }else{
          return '';
      }
}
getEntryBrand(){
    this.service.getBrand(this.myAttributes[0].brandId).subscribe(a => {
        this.myBrand = a;
        this.showme = true;
    })
}
enquire() {
  if(this.service.isLoggedIn() == false){
    this.openSnackBar('Please Login First', '');
    this.openLoginDialog();
  }else{
    this.service.notifyEnquireProductAndService(this.myBrand.name, this.heading, this.myBrand.brandId).subscribe(a => {
      this.router.navigate(['/details/brand', this.myBrand.brandId]);
    });
  }
}

openLoginDialog(): void {
  const dialogRef = this.dialog.open(LogindialogComponent);
  dialogRef.afterClosed().subscribe(result => {
  });
}

selected() {
    this.showme = false;
    this.entryId = this.selectedLevel;
    this.setupDataStreamWithId();
}
public AmIadmin(): boolean {
  return this.service.isInRole('Admin');
}
setupDataStreamWithId(){
  this.service.getEntryAttributes(this.entryId).subscribe(a => {
    this.myAttributes = a;
    this.heading = this.myAttributes[0].entryName;
    this.getEntryBrand();
    this.getEntriesByRange();
});
}
}
