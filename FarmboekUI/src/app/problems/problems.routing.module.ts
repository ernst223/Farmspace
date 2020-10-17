import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ProblemsComponent } from './problems.component';
import { ProblemsAndSolutionsComponent } from './problemsAndSolutions/problems-and-solutions.component';
import { DisplayproblembaseComponent } from './displayproblembase/displayproblembase.component';
import { DisplayproblembaseseoComponent } from './displayproblembaseseo/displayproblembaseseo.component';
import { RemediesComponent } from './remedies/remedies.component';


const routes: Routes = [{
  path: '',
  component: ProblemsComponent,
  children: [
    { path: '', redirectTo: 'problems', pathMatch: 'full' },
    { path: 'problems', component: ProblemsAndSolutionsComponent },
    { path: 'problembase/:id', component: DisplayproblembaseComponent},
    { path: 'problembase/:supergroup/:group/:subgroup/:problemname', component: DisplayproblembaseseoComponent},
    { path: 'supportedRemedies/:id', component: RemediesComponent}
  ],
  data: { breadcrumb: 'Administration' }
}];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ProblemsRoutingModule { }