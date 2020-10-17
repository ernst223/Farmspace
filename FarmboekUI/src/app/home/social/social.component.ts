import { Component, OnInit, HostListener, ViewChild, ElementRef } from '@angular/core';
import { FuseSidebarService } from '@fuse/components/sidebar/sidebar.service';
import { MediaDto, Languages, PreviousBatch } from 'app/shared/shared.models';
import { SharedService } from 'app/shared/shared.service';
import { MatDialog } from '@angular/material';
import { LogindialogComponent } from 'app/logindialog/logindialog.component';


@Component({
    selector: 'app-social',
    templateUrl: './social.component.html',
    styleUrls: ['./social.component.scss']
})
export class SocialComponent implements OnInit {

    showme = false;
    languageId = 0;
    userId = 0;
    lastId = 0;
    Posts: MediaDto[] = [];
    NextBatch: MediaDto[] = [];
    allLanguages: Languages[] = [];
    mediaIdList: number[] = [];
    previousList: PreviousBatch = {mediaId: this.mediaIdList };

    constructor(private _fuseSidebarService: FuseSidebarService, private shared: SharedService, public dialog: MatDialog) {
    }

    ngOnInit(): void {
        this.setupDataStream();
    }
    openLoginDialog(): void {
        const dialogRef = this.dialog.open(LogindialogComponent);
        dialogRef.afterClosed().subscribe(result => {

        });
    }
    
    toggleSidebar(name): void {
        this._fuseSidebarService.getSidebar(name).toggleOpen();
    }

    mediaLanguageFileter(e: any): void{
        this.languageId = e.value.id;
        this.setupDataStream();
    }
    setupDataStream(): void {
        this.shared.getLanguages().subscribe(a => {
            const tempFirst: Languages = {id: 0, language: 'All Languages'};
            this.allLanguages.push(tempFirst);
            a.forEach(element => {
                this.allLanguages.push(element);
            });
          });
        this.shared.getSocialMediaNextBatch(0, this.userId, this.languageId, this.previousList).subscribe(a => {
            this.Posts = a;
            this.lastId = this.Posts[this.Posts.length - 1].mediaId;
            this.showme = true;
            this.Posts.forEach(element => {
                this.previousList.mediaId.push(element.mediaId);
            });
        });
    }
    onScroll(): void {
        this.getNextBatch();
    }

    getNextBatch(): void {
        this.NextBatch = [];
        this.shared.getSocialMediaNextBatch(this.lastId, this.userId, this.languageId, this.previousList).subscribe(a => {
            this.NextBatch = a;
            this.lastId = a[a.length - 1].mediaId;
            this.Posts = this.Posts.concat(this.shuffleArray(this.NextBatch));
            a.forEach(element => {
                this.previousList.mediaId.push(element.mediaId);
            });
        });
    }
      shuffleArray(array): any {
        return array.sort(() => Math.random() - 0.5);
      }
}
