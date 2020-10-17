import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatSnackBarModule } from '@angular/material/snack-bar';
import { NgImageSliderModule } from 'ng-image-slider';
import { SharedModule } from 'app/shared/shared.module';
import { SharedService } from 'app/shared/shared.service';
import {NgxWigModule} from 'ngx-wig';
import { AppspageRoutingModule } from './appspage.routing.module';
import { MyappsComponent } from './myapps/myapps.component';
import { AppspageComponent } from './appspage.component';
import { DragScrollModule } from 'ngx-drag-scroll';

@NgModule({
  imports: [
    CommonModule,
    SharedModule,
    FormsModule,
    MatSnackBarModule,
    ReactiveFormsModule,
    NgImageSliderModule,
    AppspageRoutingModule,
    NgxWigModule,
    DragScrollModule
  ],
  declarations: [
  MyappsComponent,
  AppspageComponent],
  providers: [
    MatSnackBarModule,
    SharedService
  ]

})
export class AppspageModule {}
