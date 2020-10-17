import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { SharedService } from 'app/shared/shared.service';
import { BrandDto, ContactDto } from 'app/shared/shared.models';
import { environment } from 'environments/environment';

@Component({
  selector: 'app-view-brand',
  templateUrl: './view-brand.component.html',
  styleUrls: ['./view-brand.component.scss']
})
export class ViewBrandComponent implements OnInit {
    myBrandId = 0;
    myBrand: BrandDto;
    myContact: ContactDto;
    canDisplay= false;
    connectionstring = environment.imageUrl;
    viewProducts = false;
    
  constructor(private route: ActivatedRoute, private service: SharedService, private router: Router) { }

  ngOnInit() {
    this.route.params.subscribe(a => {
        this.myBrandId = a.id;
        this.setupDataStream();
    })
  }
  getImageUrl(): string{
    return this.connectionstring + this.myBrand.imageName;
  }
  setupDataStream() {
      this.service.getBrandWithImage(this.myBrandId).subscribe(o => {
          this.myBrand = o;
          this.service.getBrandContact(this.myBrand.contactId).subscribe(p => {
              this.myContact = p;
              this.canDisplay = true;
          });
      });
  }
  displayMe(): boolean {
    return this.canDisplay;
}
 viewSupplierClick() {
     this.router.navigate(['/details/suppliersbybrand/', this.myBrand.brandId]);
 }
 viewProductClick() {
    if (this.viewProducts == true) {
        this.viewProducts = false;
    } else {
        this.viewProducts = true;
    }
}
}
