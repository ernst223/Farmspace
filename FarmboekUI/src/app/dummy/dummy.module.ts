import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatSnackBarModule } from '@angular/material/snack-bar';
import { DummyComponent } from './dummy.component';
import { Dummy01Component } from './dummy01/dummy01.component';
import { SharedModule } from 'app/shared/shared.module';
import { DummyRoutingModule } from './dummy.routing.module';



@NgModule({
  imports: [
    CommonModule,
    SharedModule,
    FormsModule,
    MatSnackBarModule,
    DummyRoutingModule,
    ReactiveFormsModule
  ],
  declarations: [
    Dummy01Component,
    DummyComponent
  ],
  providers: [
    MatSnackBarModule
  ]

})
export class DummyModule {}
