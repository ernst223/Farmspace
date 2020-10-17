import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdministrationComponent } from './administration.component';
import { MediaPostsComponent } from './media-posts/media-posts.component';
import { UploadProductsComponent } from './upload-products/upload-products.component';
import { AdminUiComponent } from './admin-ui/admin-ui.component';
import { UploadSolutionComponent } from './upload-solution/upload-solution.component';
import { UploadRemediesComponent } from './upload-remedies/upload-remedies.component';
import { AdminMediaViewComponent } from './admin-media-view/admin-media-view.component';


const routes: Routes = [{
  path: '',
  component: AdministrationComponent,
  children: [
    { path: '', redirectTo: 'navigate', pathMatch: 'full' },
    { path: 'navigate', component: AdminUiComponent},
    { path: 'media-posts', component: MediaPostsComponent },
    { path: 'upload-products', component: UploadProductsComponent},
    { path: 'upload-solution', component: UploadSolutionComponent},
    { path: 'upload-remedies', component: UploadRemediesComponent},
    { path: 'admin-view-media', component: AdminMediaViewComponent}
  ],
  data: { breadcrumb: 'Home' }
}];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AdministrationRoutingModule { }