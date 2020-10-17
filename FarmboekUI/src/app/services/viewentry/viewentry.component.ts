import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, ParamMap, Router } from '@angular/router';
import { switchMap } from 'rxjs/operators';
import { SharedService } from 'app/shared/shared.service';
import { EntryAttributesDto, BrandDto, EntryRange } from 'app/shared/shared.models';
import { environment } from 'environments/environment';
import { MatDialog, MatSnackBar } from '@angular/material';
import { LogindialogComponent } from 'app/logindialog/logindialog.component';

@Component({
  selector: 'app-viewentry',
  templateUrl: './viewentry.component.html',
  styleUrls: ['./viewentry.component.scss']
})
export class ViewentryComponent implements OnInit {

    entryId = 0;
    showme = false;
    myAttributes: EntryAttributesDto[] = [];
    myBrand: BrandDto;
    myRanges: EntryRange[];
    heading = '';
    selectedLevel: any;
    connectionstring = environment.imageUrl;
    
  constructor(private snackbar: MatSnackBar, private route: ActivatedRoute, public dialog: MatDialog, private service: SharedService, private router: Router) { }

  ngOnInit() {
    this.route.params.subscribe(a => {
        this.entryId = a.id;
        this.setupDataStream();
    });
  }
  setupDataStream() {
      this.service.getEntryAttributes(this.entryId).subscribe(a => {
          this.myAttributes = a;
          this.heading = this.myAttributes[0].entryName;
          this.getEntryBrand();
          this.getEntriesByRange();
      })
  }
  getEntriesByRange() {
      this.service.getEntriesByRange(this.myAttributes[0].entryRange).subscribe(a => {
          this.myRanges = a;
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
  openSnackBar(message: string, action: string) {
    this.snackbar.open(message, action, {
      duration: 2000,
    });
  }
selected() {
    this.showme = false;
    this.entryId = this.selectedLevel;
    this.setupDataStream();
}
}
