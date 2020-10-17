import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppspageComponent } from './appspage.component';
import { MyappsComponent } from './myapps/myapps.component';



const routes: Routes = [{
  path: '',
  component: AppspageComponent,
  children: [
    { path: '', redirectTo: 'myapps', pathMatch: 'full' },
    { path: 'myapps', component: MyappsComponent}
  ],
  data: { breadcrumb: 'Home' }
}];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AppspageRoutingModule { }