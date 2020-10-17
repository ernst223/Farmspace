import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatSnackBarModule } from '@angular/material/snack-bar';
import { NgImageSliderModule } from 'ng-image-slider';
import { SharedModule } from 'app/shared/shared.module';
import { SharedService } from 'app/shared/shared.service';
import { HomeRoutingModule } from './home.routing.module';
import { HomeComponent } from './home.component';
import { SocialComponent } from './social/social.component';
import { MediaCardComponent } from './social/media-card/media-card.component';
import { FuseSidebarModule } from '@fuse/components';
import { InfiniteScrollModule } from 'ngx-infinite-scroll';
import { ViewMediaComponent } from './view-media/view-media.component';
import { NgxYoutubePlayerModule } from 'ngx-youtube-player';
import { NgxLinkPreviewModule } from 'ngx-link-preview';
import { NgxWigModule } from 'ngx-wig';
import { DragScrollModule } from 'ngx-drag-scroll';
import { ShareButtonsModule } from '@ngx-share/buttons';
import { HttpClientModule } from '@angular/common/http';
import { SearchComponent } from './search/search.component';
import { SearchProductMediaComponent } from './search-product-media/search-product-media.component';
import { ArticleMediaComponent } from './article-media/article-media.component';
import { VideoMediaComponent } from './video-media/video-media.component';
import { SearchProductComponent } from './search-product/search-product.component';

@NgModule({
  imports: [
    CommonModule,
    SharedModule,
    FormsModule,
    MatSnackBarModule,
    ReactiveFormsModule,
    NgImageSliderModule,
    HomeRoutingModule,
    FuseSidebarModule,
    InfiniteScrollModule,
    NgxYoutubePlayerModule.forRoot(),
    NgxLinkPreviewModule,
    NgxWigModule,
    DragScrollModule,
    ShareButtonsModule,
    HttpClientModule,
  ],
  declarations: [
    HomeComponent,
    SocialComponent,
    MediaCardComponent,
    ViewMediaComponent,
    SearchComponent,
    SearchProductMediaComponent,
    ArticleMediaComponent,
    VideoMediaComponent,
    SearchProductComponent
  ],
  providers: [
    MatSnackBarModule,
    SharedService
  ]

})
export class HomeModule {}
