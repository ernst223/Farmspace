import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home.component';
import { SocialComponent } from './social/social.component';
import { ViewMediaComponent } from './view-media/view-media.component';
import { SearchComponent } from './search/search.component';
import { SearchProductMediaComponent } from './search-product-media/search-product-media.component';
import { VideoMediaComponent } from './video-media/video-media.component';
import { ArticleMediaComponent } from './article-media/article-media.component';
import { SearchProductComponent } from './search-product/search-product.component';

const routes: Routes = [{
  path: '',
  component: HomeComponent,
  children: [
    { path: '', redirectTo: 'media', pathMatch: 'full' },
    { path: 'media', component: SocialComponent },
    { path: 'media/:id', component: ViewMediaComponent },
    { path: 'search/:term', component: SearchComponent},
    { path: 'searchProduct/:term', component: SearchProductComponent},
    { path: 'videoMedia', component: VideoMediaComponent},
    { path: 'articleMedia', component: ArticleMediaComponent}
  ],
  data: { breadcrumb: 'Home' }
}];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class HomeRoutingModule { }
