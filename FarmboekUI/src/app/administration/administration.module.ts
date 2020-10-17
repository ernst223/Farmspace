import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatSnackBarModule } from '@angular/material/snack-bar';
import { NgImageSliderModule } from 'ng-image-slider';
import { SharedModule } from 'app/shared/shared.module';
import { SharedService } from 'app/shared/shared.service';
import { MediaPostsComponent } from './media-posts/media-posts.component';
import { AdministrationRoutingModule } from './administration.routing.module';
import { AdministrationComponent } from './administration.component';
import {NgxWigModule} from 'ngx-wig';
import { UploadProductsComponent } from './upload-products/upload-products.component';
import { AdminUiComponent } from './admin-ui/admin-ui.component';
import { UploadSolutionComponent } from './upload-solution/upload-solution.component';
import { UploadRemediesComponent } from './upload-remedies/upload-remedies.component';
import { AdminMediaViewComponent } from './admin-media-view/admin-media-view.component';

@NgModule({
  imports: [
    CommonModule,
    SharedModule,
    FormsModule,
    MatSnackBarModule,
    ReactiveFormsModule,
    NgImageSliderModule,
    AdministrationRoutingModule,
    NgxWigModule
  ],
  declarations: [
      AdministrationComponent,
   MediaPostsComponent,
   UploadProductsComponent,
   AdminUiComponent,
   UploadSolutionComponent,
   UploadRemediesComponent,
   AdminMediaViewComponent
  ],
  providers: [
    MatSnackBarModule,
    SharedService
  ]

})
export class AdministrationModule {}