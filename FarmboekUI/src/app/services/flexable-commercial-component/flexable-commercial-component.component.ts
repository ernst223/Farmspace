import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { SharedService } from 'app/shared/shared.service';
import { MatSnackBar, MatDialog } from '@angular/material';
import { DeleteDialogComponent } from 'app/delete-dialog/delete-dialog.component';
import { Router, NavigationEnd } from '@angular/router';

@Component({
  selector: 'app-flexable-commercial-component',
  templateUrl: './flexable-commercial-component.component.html',
  styleUrls: ['./flexable-commercial-component.component.scss']
})
export class FlexableCommercialComponentComponent implements OnInit {

  addBool = false;
  valueToAdd = '';
    @Input() myInput: any[];
    @Input() Count: number; 
    @Output() myOutput = new EventEmitter();
    @Output() myAdminOutput = new EventEmitter();
  constructor(private service: SharedService, public snackBar: MatSnackBar, private router: Router, public dialog: MatDialog) { 
    this.router.routeReuseStrategy.shouldReuseRoute = function(){
      return false;
   }
   this.router.events.subscribe((evt) => {
      if (evt instanceof NavigationEnd) {
         // trick the Router into believing it's last link wasn't previously loaded
         this.router.navigated = false;
         // if you need to scroll back to top, here is the right place
         window.scrollTo(0, 0);
      }
  });
  }

  ngOnInit() {
  }

  toggleAddBool() {
    if(this.addBool == false){
      this.addBool = true;
    }else{
      this.addBool = false;
    }
  }
  ChipClicked(value: any){
      this.myOutput.emit({id: value, count: this.Count});
  }

  AdminChipClicked(){
    this.myAdminOutput.emit({desc: this.valueToAdd, count: this.Count});
  }
  public AmIadmin(): boolean {
    return this.service.isInRole('admin');
  }

  addValue() {
    if(this.valueToAdd == ''){
      this.snackBar.open('No value to add', '', { duration: 2500, }).afterDismissed().subscribe(() => { });
    }else{
      this.AdminChipClicked();
    }
  }

  delete(id: any) {
    this.openDialog(id);
  }
  openDialog(id: any): void {
    const dialogRef = this.dialog.open(DeleteDialogComponent, {
      width: '400px'
    });

    dialogRef.afterClosed().subscribe(result => {
     if(result == true){
      this.makeTheDelete(id);
     }
    });
  }

  makeTheDelete(id : any){
    if (this.Count == 1) {
      //Delete SuperGroup
      this.service.deleteSuperGroup(id).subscribe(a => {
        this.endMyDeleteSesion(a);
      });
    } else if (this.Count == 2) {
      //Delete Group
      this.service.deleteGroup(id).subscribe(a => {
        this.endMyDeleteSesion(a);
      });
    } else if (this.Count == 3) {
      //Delete SubGroup
      this.service.deleteSubGroup(id).subscribe(a => {
        this.endMyDeleteSesion(a);
      });
    }
  }
  endMyDeleteSesion(a: any){
    // console.log(a);
    if (a == true) {
      this.router.navigate(['/productsAndServices']);
    }else{
      this.snackBar.open('Oops something went wrong', '', { duration: 2500, }).afterDismissed().subscribe(() => { });
    }
  }
}
