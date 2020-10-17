import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SupplierdetailComponent } from './supplierdetail.component';
import { ViewSupplierComponent } from './view-supplier/view-supplier.component';
import { SuppliersComponent } from './suppliers/suppliers.component';
import { ViewBrandComponent } from './view-brand/view-brand.component';


const routes: Routes = [{
  path: '',
  component: SupplierdetailComponent,
  children: [
    { path: '', redirectTo: 'supplier/1', pathMatch: 'full' },
    { path: 'supplier/:id', component: ViewSupplierComponent },
    { path: 'brand/:id', component: ViewBrandComponent },
    { path: 'suppliersbybrand/:id', component: SuppliersComponent}
  ],
  data: { breadcrumb: 'Administration' }
}];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class SupplierdetailRoutingModule { }