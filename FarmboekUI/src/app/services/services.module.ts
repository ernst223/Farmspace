import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatSnackBarModule } from '@angular/material/snack-bar';
import { SharedModule } from 'app/shared/shared.module';
import { ServicesRoutingModule } from './services.routing.module';
import { ServicesComponent } from './services.component';
import { ProductAndServicesComponent } from './productsAndServices/product-and-services.component';
import { FlexableCommercialComponentComponent } from './flexable-commercial-component/flexable-commercial-component.component';
import { SharedService } from 'app/shared/shared.service';
import { FlexableRouteEntryComponent } from './flexable-route-entry/flexable-route-entry.component';
import { ViewentryComponent } from './viewentry/viewentry.component';
import { ViewentryseoComponent } from './viewentryseo/viewentryseo.component';
import { NgxYoutubePlayerModule } from 'ngx-youtube-player';
import { NgxLinkPreviewModule } from 'ngx-link-preview';
import { MediaProductCardComponent } from './media-product-card/media-product-card.component';
import { FuseSidebarModule } from '@fuse/components';
import { DragScrollModule } from 'ngx-drag-scroll';

@NgModule({
  imports: [
    CommonModule,
    SharedModule,
    FormsModule,
    MatSnackBarModule,
    ServicesRoutingModule,
    ReactiveFormsModule,
    NgxYoutubePlayerModule.forRoot(),
    NgxLinkPreviewModule,
    FuseSidebarModule,
    DragScrollModule
  ],
  declarations: [
    ServicesComponent,
    ProductAndServicesComponent,
    FlexableCommercialComponentComponent,
    FlexableRouteEntryComponent,
    ViewentryComponent,
    ViewentryseoComponent,
    MediaProductCardComponent,
  ],
  providers: [
    MatSnackBarModule,
    SharedService
  ]

})
export class ServicesModule {}
