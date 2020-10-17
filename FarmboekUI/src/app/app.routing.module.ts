import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { SignupComponent } from './signup/signup.component';
import { RemediesComponent } from './remedies/remedies.component';
import { ResetpasswordComponent } from './resetpassword/resetpassword.component';
import { ForgotpasswordComponent } from './forgotpassword/forgotpassword.component';


const routes: Routes = [
  {
    path: '',
    children: [
      { path: '', redirectTo: 'home', pathMatch: 'full',  },
      { path: 'home', loadChildren: './home/home.module#HomeModule'},
      { path: 'administration', loadChildren: './administration/administration.module#AdministrationModule'},
      { path: 'problemsAndSolutions', loadChildren: './problems/problems.module#ProblemsModule'},
      { path: 'productsAndServices', loadChildren: './services/services.module#ServicesModule'},
      { path: 'details', loadChildren: './supplier-details/supplierdetail.module#SupplierdetailModule'},
      { path: 'register', component: SignupComponent},
      { path: 'remedy/:id', component: RemediesComponent},
      { path: 'resetpassword/:username/:token', component: ResetpasswordComponent},
      { path: 'forgotpassword', component: ForgotpasswordComponent},
      { path: 'appspage', loadChildren: './appspage/appspage.module#AppspageModule'}
    ]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
  providers: []
})

export class AppRoutingModule {
}
