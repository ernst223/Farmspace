import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { ProductBaseDto, RemedyProblems,  BrandDto, RouteProblemDto, ActiveIngredientDto, pdfDTO} from 'app/shared/shared.models';
import { SharedService } from 'app/shared/shared.service';
import { Router, ActivatedRoute } from '@angular/router';
import { environment } from 'environments/environment';
import { MatSnackBar, MatDialog } from '@angular/material';
import { LogindialogComponent } from 'app/logindialog/logindialog.component';

@Component({
  selector: 'app-remedies',
  templateUrl: './remedies.component.html',
  styleUrls: ['./remedies.component.scss']
})
export class RemediesComponent implements OnInit {
    showDetails = false;
    remedyDetails: ProductBaseDto;
    remedyProblems: RemedyProblems[] = [];
    displayRemedyProblems = false;
    myActiveIngredients: ActiveIngredientDto[] = [];
    brand: BrandDto;
    connectionstring = environment.imageUrl;
    id = 0;
    myInput: ProductBaseDto[];
    @Output() myOutput = new EventEmitter();
    theFile: any;
  fileName: any;
  myPDFupload: pdfDTO;
  constructor(private service: SharedService, private router: Router,public dialog: MatDialog, private route: ActivatedRoute, private snackbar: MatSnackBar) { }

  ngOnInit() {
    this.route.params.subscribe(a => {
      this.id = a.id;
      this.getRemedies();
    });
  }
  changeShowRemedies() {
    this.myOutput.emit();
  }
  getRemedies() {
    this.service.getRemedies(this.id).subscribe(a => {
      this.myInput = a;
  });
  }
  getImageConnectionString(image: any): string {
    return this.connectionstring + image;
}
public AmIadmin(): boolean {
  return this.service.isInRole('Admin');
}
OpenImage(event: any) {
  // The file is in this event
    this.theFile = event.target.files[0];
    this.fileName = event.target.files[0].name;
    const reader = new FileReader();
    reader.readAsDataURL(this.theFile);
    let result;
    reader.onload = (e) => {
      result = reader.result;
      this.myPDFupload = {
        thePDF: result,
        thePDFName: this.id + '.pdf',
        id: +this.id
      }
      this.service.postProductBasePDF(this.myPDFupload).subscribe(a => {
        this.openSnackBar('uploaded', '');
      });
  }
}
deletePDF() {
    this.service.deleteProductBasePDF(this.id).subscribe(a => {
      // console.log('Delete result' + a);
      this.openSnackBar('PDF deleted', '');
    });
  
}
openPDFConnectionString() {
    let url = environment.pdfURL + 'ProductBasePDF/' + this.id + '.pdf';
    window.open(url);
}
openSnackBar(message: string, action: string) {
  this.snackbar.open(message, action, {
    duration: 2000,
  });
}
  chipClicked(value: any){
      this.remedyDetails = this.myInput.find(o => o.productBaseId === value);
      this.getBrand();
      this.getRemedyProblems();
      this.displayRemedyProblems = false;
      this.getActiveIngredient();
      this.showDetails = true;
      
      // console.log('Scrolling down');
      var container = document.getElementById('Container');
      container.scrollTop = container.scrollHeight;
  }
  getBrand() {
    this.service.getBrand(this.remedyDetails.brandId).subscribe(a => {
      this.brand = a;
    });
  }
  getActiveIngredient() {
      this.service.getActiveIngredient(this.remedyDetails.productBaseId).subscribe(a => {
          this.myActiveIngredients = a;
      });
  }
  showActiveIngredient(): boolean {
      if(this.getActiveIngredient.length < 0){
          return false;
      }else {
          return true;
      }
  }
  getRemedyProblems() {
    this.service.getRemedyProblems(this.remedyDetails.productBaseId).subscribe(a => {
      this.remedyProblems = a;
      this.displayRemedyProblems = true;
    });
  }
  enquire() {
      if(this.service.isLoggedIn() == false){
        this.openSnackBar('Please Login First', '');
        this.openLoginDialog();
      }else{
        this.service.notifyEnquireRemedies(this.remedyDetails).subscribe(a => {
          this.router.navigate(['/details/suppliersbybrand', this.remedyDetails.brandId]);
        });
      }
  }
  openLoginDialog(): void {
    const dialogRef = this.dialog.open(LogindialogComponent);
    dialogRef.afterClosed().subscribe(result => {
    });
}
  goToProblemBaseSeo(problembaseId: any) {
    let re = /\ /gi;
    this.service.getProblemDetailsforseo(problembaseId).subscribe(a => {
      let pSupergroup = a.supergroup.replace(re, '_');
      let pGroup = a.group.replace(re, '_');
      let pSubgroup = a.subgroup.replace(re, '_');
      let pProblemname = a.problemname.replace(re, '_');
      this.router.navigate(['/problemsAndSolutions/problembase', pSupergroup , pGroup,
       pSubgroup, pProblemname]);
    });
  }
}
