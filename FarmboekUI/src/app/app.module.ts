import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { RouterModule, Routes } from '@angular/router';
import { MatMomentDateModule } from '@angular/material-moment-adapter';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { TranslateModule } from '@ngx-translate/core';
import 'hammerjs';

import { FuseModule } from '@fuse/fuse.module';
import { FuseSharedModule } from '@fuse/shared.module';
import { FuseProgressBarModule, FuseSidebarModule, FuseThemeOptionsModule } from '@fuse/components';

import { fuseConfig } from 'app/fuse-config';

import { AppComponent } from 'app/app.component';
import { LayoutModule } from 'app/layout/layout.module';
import { ReactiveFormsModule } from '@angular/forms';
import { SharedModule } from './shared/shared.module';
import { FlexLayoutModule } from '@angular/flex-layout';
import { AppRoutingModule } from './app.routing.module';
import { LogindialogComponent } from './logindialog/logindialog.component';
import { MatDialogModule, MatSnackBarModule } from '@angular/material';
import { SignupComponent } from './signup/signup.component';
import { SharedService } from './shared/shared.service';
import { MatLinkPreviewModule } from '@angular-material-extensions/link-preview';
import { NgxYoutubePlayerModule } from 'ngx-youtube-player';
import { DeleteDialogComponent } from './delete-dialog/delete-dialog.component';
import { RemediesComponent } from './remedies/remedies.component';
import { CountriesService } from './shared/countries.service';
import { ResetpasswordComponent } from './resetpassword/resetpassword.component';
import { ForgotpasswordComponent } from './forgotpassword/forgotpassword.component';
import { DragScrollModule } from 'ngx-drag-scroll';
import { FontAwesomeModule, FaIconLibrary } from '@fortawesome/angular-fontawesome';
import { faWhatsapp } from '@fortawesome/free-brands-svg-icons/faWhatsapp';
import { faFacebookMessenger } from '@fortawesome/free-brands-svg-icons/faFacebookMessenger';
import { faFacebookF } from '@fortawesome/free-brands-svg-icons/faFacebookF';

@NgModule({
    declarations: [
        AppComponent,
        LogindialogComponent,
        SignupComponent,
        DeleteDialogComponent,
        RemediesComponent,
        ResetpasswordComponent,
        ForgotpasswordComponent,
    ],
    entryComponents: [
        LogindialogComponent,
        DeleteDialogComponent
    ],
    providers: [
        SharedService, CountriesService
    ],
    imports: [
        BrowserModule,
        NgxYoutubePlayerModule.forRoot(),
        MatLinkPreviewModule.forRoot(),
        BrowserAnimationsModule,
        HttpClientModule,
        ReactiveFormsModule,
        SharedModule,
        FlexLayoutModule,
        AppRoutingModule,
        DragScrollModule,
        FontAwesomeModule,
        TranslateModule.forRoot(),
        

        // Material moment date module
        MatMomentDateModule,

        // Material
        MatButtonModule,
        MatIconModule,
        MatDialogModule,
        MatSnackBarModule,

        // Fuse modules
        FuseModule.forRoot(fuseConfig),
        FuseProgressBarModule,
        FuseSharedModule,
        FuseSidebarModule,
        FuseThemeOptionsModule,

        // App modules
        LayoutModule,
    ],
    bootstrap   : [
        AppComponent
    ]
})
export class AppModule
{
    constructor(library: FaIconLibrary) {
        library.addIcons(faWhatsapp);
        library.addIcons(faFacebookMessenger);
        library.addIcons(faFacebookF);
    }
}
