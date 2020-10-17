import { NgModule } from '@angular/core';
import {
  MatButtonModule,
  MatStepperModule,
  MatCardModule,
  MatDialogModule,
  MatIconModule,
  MatInputModule,
  MatListModule,
  MatMenuModule,
  MatPaginatorModule,
  MatProgressBarModule,
  MatSelectModule,
  MatSidenavModule,
  MatTableModule,
  MatSortModule,
  MatTabsModule,
  MatToolbarModule,
  MatAutocompleteModule,
  MatDatepickerModule,
  MatNativeDateModule,
  MatExpansionModule,
  MatCheckboxModule,
  MatSlideToggleModule,
  MatGridListModule,
  MatProgressSpinner,
  MatProgressSpinnerModule,
  MatTooltipModule,
  MatBadgeModule
} from '@angular/material';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';


const modules = [
  MatCardModule,
  MatIconModule,
  MatInputModule,
  MatButtonModule,
  MatListModule,
  MatDialogModule,
  MatProgressBarModule,
  MatToolbarModule,
  MatMenuModule,
  MatStepperModule,
  MatSidenavModule,
  MatSelectModule,
  MatTabsModule,
  MatTableModule,
  MatSortModule,
  MatPaginatorModule,
  MatAutocompleteModule,
  MatDatepickerModule,
  MatNativeDateModule,
  MatExpansionModule,
  MatCheckboxModule,
  MatGridListModule,
  MatSlideToggleModule,
  MatProgressSpinnerModule,
  MatTooltipModule,
  MatBadgeModule
];

@NgModule({
  imports: modules,
  exports: modules
})
export class MaterialComponentsModule { }
