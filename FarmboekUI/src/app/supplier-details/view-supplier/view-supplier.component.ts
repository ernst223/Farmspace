import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { SupplierDto } from 'app/shared/shared.models';
import { SharedService } from 'app/shared/shared.service';
import { environment } from 'environments/environment';
import { MatSnackBar } from '@angular/material';

@Component({
  selector: 'app-view-supplier',
  templateUrl: './view-supplier.component.html',
  styleUrls: ['./view-supplier.component.scss']
})
export class ViewSupplierComponent implements OnInit {
  supplierId = 0;
  mySupplier: SupplierDto;
  canDisplay= false;
  connectionstring = environment.imageUrl;
  viewBrands = false;
  viewProducts = false;
  constructor(private route: ActivatedRoute, private service: SharedService, public snackBar: MatSnackBar) { }

  ngOnInit() {
    this.route.params.subscribe(a => {
        // console.log(a.id);
        this.supplierId = a.id;
    })

    this.service.getSupplier(this.supplierId).subscribe(a => {
        this.mySupplier = a;
        // console.log(a);
        this.canDisplay = true;
    });
  }

  viewBrandsClick() {
      if (this.viewBrands == true){
          this.viewBrands = false;
      } else {
          this.viewBrands = true;
          this.snackBar.open('Scroll down', '', { duration: 2500, }).afterDismissed().subscribe(() => { });
      }
  }

  viewProductClick() {
      if (this.viewProducts == true) {
          this.viewProducts = false;
      } else {
          this.viewProducts = true;
      }
  }
  getImageUrl(): string{
     return this.connectionstring + this.mySupplier.imageName;
  }
  displayMe(): boolean {
      return this.canDisplay;
  }
  
}
