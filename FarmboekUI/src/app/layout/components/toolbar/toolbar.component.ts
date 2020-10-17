import { Component, OnDestroy, OnInit, ViewEncapsulation } from '@angular/core';
import { Subject } from 'rxjs';
import { takeUntil } from 'rxjs/operators';
import { TranslateService } from '@ngx-translate/core';
import * as _ from 'lodash';

import { FuseConfigService } from '@fuse/services/config.service';
import { FuseSidebarService } from '@fuse/components/sidebar/sidebar.service';

import { navigation } from 'app/navigation/navigation';
import { SharedService } from 'app/shared/shared.service';
import { LogindialogComponent } from 'app/logindialog/logindialog.component';
import { MatDialog } from '@angular/material';
import { Router, NavigationEnd } from '@angular/router';
import { LoggedUserInfo } from 'app/shared/shared.models';

@Component({
    selector     : 'toolbar',
    templateUrl  : './toolbar.component.html',
    styleUrls    : ['./toolbar.component.scss'],
    encapsulation: ViewEncapsulation.None
})

export class ToolbarComponent implements OnInit, OnDestroy
{
    horizontalNavbar: boolean;
    rightNavbar: boolean;
    hiddenNavbar: boolean;
    languages: any;
    searchedValue = '';
    navigation: any;
    selectedLanguage: any;
    userStatusOptions: any[];
    nameHeading = 'Login';
    loggedUser: LoggedUserInfo;
    // Private
    private _unsubscribeAll: Subject<any>;

    /**
     * Constructor
     *
     * @param {FuseConfigService} _fuseConfigService
     * @param {FuseSidebarService} _fuseSidebarService
     * @param {TranslateService} _translateService
     */
    constructor(
        private _fuseConfigService: FuseConfigService,
        private _fuseSidebarService: FuseSidebarService,
        private _translateService: TranslateService,
        private service: SharedService,
        public dialog: MatDialog,
        private route: Router,
        private shared: SharedService
    )
    {
        this.route.routeReuseStrategy.shouldReuseRoute = function() {
            return false;
         };
        this.route.events.subscribe((evt) => {
            if (evt instanceof NavigationEnd) {
               // trick the Router into believing it's last link wasn't previously loaded
               this.route.navigated = false;
               // if you need to scroll back to top, here is the right place
               window.scrollTo(0, 0);
            }
        });
        // Set the defaults
        this.userStatusOptions = [
            {
                title: 'Online',
                icon : 'icon-checkbox-marked-circle',
                color: '#4CAF50'
            },
            {
                title: 'Away',
                icon : 'icon-clock',
                color: '#FFC107'
            },
            {
                title: 'Do not Disturb',
                icon : 'icon-minus-circle',
                color: '#F44336'
            },
            {
                title: 'Invisible',
                icon : 'icon-checkbox-blank-circle-outline',
                color: '#BDBDBD'
            },
            {
                title: 'Offline',
                icon : 'icon-checkbox-blank-circle-outline',
                color: '#616161'
            }
        ];

        this.languages = [
            {
                id   : 'en',
                title: 'English',
                flag : 'us'
            },
            {
                id   : 'tr',
                title: 'Turkish',
                flag : 'tr'
            }
        ];

        this.navigation = navigation;

        // Set the private defaults
        this._unsubscribeAll = new Subject();
    }

    // -----------------------------------------------------------------------------------------------------
    // @ Lifecycle hooks
    // -----------------------------------------------------------------------------------------------------

    /**
     * On init
     */
    ngOnInit(): void
    {
        // Subscribe to the config changes
        this._fuseConfigService.config
            .pipe(takeUntil(this._unsubscribeAll))
            .subscribe((settings) => {
                this.horizontalNavbar = settings.layout.navbar.position === 'top';
                this.rightNavbar = settings.layout.navbar.position === 'right';
                this.hiddenNavbar = settings.layout.navbar.hidden === true;
            });

        // Set the selected language from default languages
        this.selectedLanguage = _.find(this.languages, {id: this._translateService.currentLang});

        if (this.isLoggedIn()){
            this.loggedUser = this.service.getLoggedUserDetails();
            this.nameHeading = this.loggedUser.firstname;
        }
      //  document.addEventListener('keydown', this.keyboardInput);
    }

    search(value): void
    {
       console.log(value.srcElement.value);
       this.searchedValue = value.srcElement.value;
    }

    keyboardInputCaptured(): void
    {
       console.log(this.searchedValue);
       this.route.navigate(['home/search/', this.searchedValue]);
    }
    keyboardInput(event: KeyboardEvent) {
        // console.log(this.searchedValue);
        if (event.keyCode === 13) {
            console.log(this.searchedValue);
            this.route.navigate(['home/search/', this.searchedValue]);
        }
    }
    myIViewThis(): boolean{
        return this.shared.isInRole('Admin');
      }

    isLoggedIn(): boolean {
        const test = this.service.isLoggedIn();
        if (test == true){
            this.loggedUser = this.service.getLoggedUserDetails();
            this.nameHeading = this.loggedUser.firstname;
            return true;
        }else{
            this.nameHeading = 'Login';
            return false;
        }
    }
    login() {
        this.openLoginDialog();
    }

    openLoginDialog(): void {
        const dialogRef = this.dialog.open(LogindialogComponent);
        dialogRef.afterClosed().subscribe(result => {
        });
    }
    logout() {
        this.service.clearLocalStorage();
        this.route.navigate(['/home/media']);
    }
    /**
     * On destroy
     */
    ngOnDestroy(): void
    {
        // Unsubscribe from all subscriptions
        this._unsubscribeAll.next();
        this._unsubscribeAll.complete();
    }

    // -----------------------------------------------------------------------------------------------------
    // @ Public methods
    // -----------------------------------------------------------------------------------------------------

    /**
     * Toggle sidebar open
     *
     * @param key
     */
    toggleSidebarOpen(key): void
    {
        this._fuseSidebarService.getSidebar(key).toggleOpen();
    }

    /**
     * Search
     *
     * @param value
     */
    

    /**
     * Set the language
     *
     * @param lang
     */
    setLanguage(lang): void
    {
        // Set the selected language for the toolbar
        this.selectedLanguage = lang;

        // Use the selected language for translations
        this._translateService.use(lang.id);
    }

    toggleSidebar(name): void
    {
        this._fuseSidebarService.getSidebar(name).toggleOpen();
    }
}
