import { Component, OnInit, Input, ViewChild } from '@angular/core';
import { environment } from 'environments/environment';
import { ActivatedRoute, Router } from '@angular/router';
import { SupplierDto, Province } from 'app/shared/shared.models';
import { SharedService } from 'app/shared/shared.service';
import { MatStepper } from '@angular/material';
import { Route } from '@angular/compiler/src/core';

@Component({
  selector: 'app-suppliers',
  templateUrl: './suppliers.component.html',
  styleUrls: ['./suppliers.component.scss']
})
export class SuppliersComponent implements OnInit {

    mySuppliers: SupplierDto[] = [];
    myStep2Suppliers: SupplierDto[] = [];
    provinces: Province[] = [];
    myProvinces: Province[] = [];
    selectedProvice = 0;
    myBrandId = 0;
    canIdisplay = false;
    connectionstring = environment.imageUrl;
    @ViewChild('stepper', { static: false }) private myStepper: MatStepper;

  constructor(private route: ActivatedRoute, private service: SharedService, private router: Router) { }

  ngOnInit() {
    this.route.params.subscribe(a => {
        this.myBrandId = a.id;
        this.setupDataStream();
    })
  }
  setupDataStream() {
      this.service.getProvinces().subscribe(p => {
          this.provinces = p;
        this.service.getSuppliersByBrand(this.myBrandId).subscribe(a => {
            this.mySuppliers = a;
            this.setMyProvinces();
            this.canIdisplay = true;
        });
      });
   }
   setMyProvinces() {
       this.provinces.forEach(element => {
           if(this.mySuppliers.some(o => o.provinceId === element.provinceId)){
               this.myProvinces.push(element);
           }
       });
   }
  getImageUrl(image: any){
      return this.connectionstring + image;
  }
  step1Clicked(id: any){
      this.selectedProvice = id;
      this.myStep2Suppliers = [];
      this.getStep2Suppliers();
     this.myStepper.next();
  }
  getStep2Suppliers() {
        this.mySuppliers.filter(x => x.provinceId == this.selectedProvice).forEach(subElement => {
            this.myStep2Suppliers.push(subElement);
        });
        // console.log(this.myStep2Suppliers);
  }
  step2Clicked(id: any){
      this.router.navigate(['/details/supplier', id]);
  }
  getImageConnectionString(image: any): string {
    return this.connectionstring + image;
}
}
