import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { DummyProblems } from 'app/shared/shared.models';
import { SharedService } from 'app/shared/shared.service';
import { WeekDay } from '@angular/common';
import { MatSnackBar, MatDialog } from '@angular/material';
import { Router, NavigationEnd } from '@angular/router';
import { DeleteDialogComponent } from 'app/delete-dialog/delete-dialog.component';

@Component({
  selector: 'app-flexable-problems-and-solutions',
  templateUrl: './flexable-problems-and-solutions.component.html',
  styleUrls: ['./flexable-problems-and-solutions.component.scss']
})
export class FlexableProblemsAndSolutionsComponent implements OnInit {
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
    return this.service.isInRole('Admin');
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
      this.router.navigate(['/problemsAndSolutions']);
    }else{
      this.snackBar.open('Oops something went wrong', '', { duration: 2500, }).afterDismissed().subscribe(() => { });
    }
  }
}
