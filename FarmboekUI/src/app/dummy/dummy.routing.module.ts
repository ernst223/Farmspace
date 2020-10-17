import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { Dummy01Component } from './dummy01/dummy01.component';
import { DummyComponent } from './dummy.component';


const routes: Routes = [{
  path: '',
  component: DummyComponent,
  children: [
    { path: '', redirectTo: 'dummy', pathMatch: 'full' },
    { path: 'dummy', component: Dummy01Component }
  ],
  data: { breadcrumb: 'Administration' }
}];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class DummyRoutingModule { }