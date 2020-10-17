import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatSnackBarModule } from '@angular/material/snack-bar';
import { SharedModule } from 'app/shared/shared.module';
import { ProblemsAndSolutionsComponent } from './problemsAndSolutions/problems-and-solutions.component';
import { ProblemsComponent } from './problems.component';
import { ProblemsRoutingModule } from './problems.routing.module';
import { SharedService } from 'app/shared/shared.service';
import { FlexableProblemsAndSolutionsComponent } from './flexableComponent/flexable-problems-and-solutions.component';
import { FlexableRouteProblemsComponentComponent } from './flexableRouteProblemsComponent/flexable-route-problems-component.component';
import { SolutionresultComponent } from './solutionresult/solutionresult.component';
import {SlideshowModule} from 'ng-simple-slideshow';
import { RemediesComponent } from './remedies/remedies.component';
import { DisplayproblembaseComponent } from './displayproblembase/displayproblembase.component';
import { DisplayproblembaseseoComponent } from './displayproblembaseseo/displayproblembaseseo.component';
import { FuseSidebarModule } from '@fuse/components';
import { GalleryModule } from '@ngx-gallery/core';
import { DragScrollModule } from 'ngx-drag-scroll';


@NgModule({
  imports: [
    CommonModule,
    SharedModule,
    FormsModule,
    MatSnackBarModule,
    ProblemsRoutingModule,
    ReactiveFormsModule,
    SlideshowModule,
    FuseSidebarModule,
    GalleryModule,
    DragScrollModule
  ],
  declarations: [
    ProblemsComponent,
    ProblemsAndSolutionsComponent,
    FlexableProblemsAndSolutionsComponent,
    FlexableRouteProblemsComponentComponent,
    SolutionresultComponent,
    RemediesComponent,
    DisplayproblembaseComponent,
    DisplayproblembaseseoComponent,
  ],
  providers: [
    MatSnackBarModule,
    SharedService
  ]

})
export class ProblemsModule {}
