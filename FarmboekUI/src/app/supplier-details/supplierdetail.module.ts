import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatSnackBarModule } from '@angular/material/snack-bar';
import { SharedModule } from 'app/shared/shared.module';
import { SupplierdetailComponent } from './supplierdetail.component';
import { SupplierdetailRoutingModule } from './supplierdetail.routing.module';
import { ViewSupplierComponent } from './view-supplier/view-supplier.component';
import { SharedService } from 'app/shared/shared.service';
import { BrandsComponent } from './brands/brands.component';
import { ProductsComponent } from './products/products.component';
import { SuppliersComponent } from './suppliers/suppliers.component';
import { ViewBrandComponent } from './view-brand/view-brand.component';




@NgModule({
  imports: [
    CommonModule,
    SharedModule,
    FormsModule,
    MatSnackBarModule,
    SupplierdetailRoutingModule,
    ReactiveFormsModule
  ],
  declarations: [
    SupplierdetailComponent,
    ViewSupplierComponent,
    BrandsComponent,
    ProductsComponent,
    SuppliersComponent,
    ViewBrandComponent
  ],
  providers: [
    MatSnackBarModule,
    SharedService
  ]

})
export class SupplierdetailModule {}
