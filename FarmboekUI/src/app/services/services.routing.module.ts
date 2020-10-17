import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ServicesComponent } from './services.component';
import { ProductAndServicesComponent } from './productsAndServices/product-and-services.component';
import { ViewentryComponent } from './viewentry/viewentry.component';
import { ViewentryseoComponent } from './viewentryseo/viewentryseo.component';

const routes: Routes = [{
  path: '',
  component: ServicesComponent,
  children: [
    { path: '', redirectTo: 'products', pathMatch: 'full' },
    { path: 'products', component: ProductAndServicesComponent },
    { path: 'entry/:id', component: ViewentryComponent},
    { path: 'entry/:supergroup/:group/:subgroup/:brand/:productname', component: ViewentryseoComponent}
  ],
  data: { breadcrumb: 'Administration' }
}];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ServicesRoutingModule { }