import { Component, OnInit, Input } from '@angular/core';
import { MediaDto, EditPostDto } from 'app/shared/shared.models';
import { SharedService } from 'app/shared/shared.service';
import { MatDialog, MatSnackBar } from '@angular/material';
import { LogindialogComponent } from 'app/logindialog/logindialog.component';
import { environment } from 'environments/environment';
import { HttpClient } from '@angular/common/http';
import { DeleteDialogComponent } from 'app/delete-dialog/delete-dialog.component';
import { Router } from '@angular/router';
import { Title } from '@angular/platform-browser';


@Component({
    selector: 'app-media-card',
    templateUrl: './media-card.component.html',
    styleUrls: ['./media-card.component.scss']
})
export class MediaCardComponent implements OnInit {
    userId = 0;
    @Input() myInput: MediaDto;
    thisMedia: MediaDto;
    editPostObj: EditPostDto;
    uploadImageLabel = 'add or replace Image';
    theFile: any;
    fileName: any;
    showShare: boolean = false;
    myUrl = 'https://farmspace.co.za/api/socialmedia/share/';
    imageUrl = 'https://farmspace.co.za/assets/images/logos/logo_small_farmspace.png';
    htmlToAdd = '';
    htmlToAddTemp = '';
    titleTemp = '';
    myComment = '';
    editme = false;
    connectionstring = environment.apiUrl;
    displayCommentInput = false;
    playerVars = {
        cc_lang_pref: 'en'
    };
    private player;
    private ytEvent;
    constructor(private service: SharedService, public snackBar: MatSnackBar, private titleService: Title,
        public dialog: MatDialog, private httpClient: HttpClient, private router: Router) { }

    ngOnInit() {
        this.thisMedia = this.myInput;
        this.htmlToAdd = this.myInput.description;
        this.htmlToAddTemp = this.myInput.description;
        this.titleTemp = this.myInput.title;
        this.myUrl += this.myInput.mediaId;
        if (this.thisMedia.imageUrl == '' || this.thisMedia.imageUrl == undefined) {
            this.imageUrl = 'https://farmspace.co.za/assets/images/logos/logo_small_farmspace.png';
        } else {
            this.imageUrl = this.thisMedia.imageUrl;
        }
    }

    IncreaseShareCount() {

    }
    canShowLink(): boolean {
        if (this.myInput.webLink != '') {
            if (this.myInput.webLink != undefined) {
                return true
            } else {
                return false;
            }
        } else {
            return false;
        }
    }
    getImageUrl(imageUrl: string): string {
        return this.connectionstring + imageUrl;
    }

    public apiCallbackFn = (route: string) => {
        return this.httpClient.get(route);
    }

    myIViewThis(): boolean {
        return this.service.isInRole('Admin');
    }

    enableReadMore(): boolean {
        if (+this.thisMedia.commentCount > 2) {
            return true;
        } else {
            return false;
        }
    }

    editPost() {
        this.editme = true;
    }

    cancleEdit() {
        this.editme = false;
        this.htmlToAddTemp = this.myInput.description;
        this.titleTemp = this.myInput.title;
    }
    saveEdit() {
        if (this.theFile == undefined) {
            this.editPostObj = { title: this.titleTemp, description: this.htmlToAddTemp, newImage: '', fileName: ''};
            this.service.editPost(this.editPostObj, this.myInput.mediaId).subscribe(a => {
                this.snackBar.open('Updated', '', { duration: 2500, }).afterDismissed().subscribe(() => { });
                this.myInput.title = this.titleTemp;
                this.htmlToAdd = this.htmlToAddTemp;
                this.editme = false;
                this.setupDataStream();
            });
        }else{
            const reader = new FileReader();
            reader.readAsDataURL(this.theFile);
            let result;
            reader.onload = (e) => {
                result = reader.result;
                // console.log(result);
                this.editPostObj = { title: this.titleTemp, description: this.htmlToAddTemp, newImage: result, fileName: this.fileName};
                this.service.editPost(this.editPostObj, this.myInput.mediaId).subscribe(a => {
                this.snackBar.open('Updated', '', { duration: 2500, }).afterDismissed().subscribe(() => { });
                this.myInput.title = this.titleTemp;
                this.htmlToAdd = this.htmlToAddTemp;
                this.editme = false;
                this.setupDataStream();
            });
              };
        }
    }
    OpenImage(event: any): void {
        // The file is in this event
        // console.log(event.target.files[0].name);
        this.uploadImageLabel = event.target.files[0].name;
        this.theFile = event.target.files[0];
        this.fileName = event.target.files[0].name;
    }
    removeImage(): void {
        this.service.deleteImage(this.thisMedia.mediaId).subscribe(a => {
            console.log(a);
            this.snackBar.open('Image Deleted', '', { duration: 2500, }).afterDismissed().subscribe(() => { });
            this.setupDataStream();
        });
    }
    deleteMedia(): void {
        this.openDialog();
    }
    openDialog(): void {
        const dialogRef = this.dialog.open(DeleteDialogComponent, {
            width: '400px'
        });

        dialogRef.afterClosed().subscribe(result => {
            if (result == true) {
                this.makeTheDelete();
            }
        });
    }
    makeTheDelete() {
        this.service.deleteMedia(this.myInput.mediaId).subscribe(a => {
            this.router.navigate(['/home/media']);
        });
    }
    likePost() {
        if (this.service.isLoggedIn()) {
            if (this.thisMedia.likeStatus == true) {
                this.service.UnlikePost(this.myInput.mediaId, this.userId).subscribe(a => {
                    // console.log('Post Unlike');
                    this.setupDataStream();
                });
            } else {
                this.service.likePost(this.myInput.mediaId, this.userId).subscribe(a => {
                    // console.log('Post Liked');
                    this.setupDataStream();
                });
            }
        } else {
            this.snackBar.open('Please Login first', '', { duration: 2500, }).afterDismissed().subscribe(() => { });
            this.openLoginDialog();
        }
        this.displayCommentInput = false;
    }

    ShareClicked() {

        if (this.showShare == true) {
            this.titleService.setTitle('Farmspace');
            this.showShare = false;
        } else {
            this.titleService.setTitle(this.myInput.title);
            this.showShare = true;
        }
    }
    openLoginDialog(): void {
        const dialogRef = this.dialog.open(LogindialogComponent);
        dialogRef.afterClosed().subscribe(result => {
        });
    }

    onStateChange(event) {
        this.ytEvent = event.data;
    }
    savePlayer(player) {
        this.player = player;
    }

    playVideo() {
        this.player.playVideo();
    }

    pauseVideo() {
        this.player.pauseVideo();
    }

    postComment() {
        if (this.service.isLoggedIn()) {
            this.service.addComment(this.thisMedia.mediaId, this.userId, this.myComment).subscribe(a => {
                this.setupDataStream();
                this.displayCommentInput = false;
                this.myComment = '';
            });
        } else {
            this.snackBar.open('Please Login first', '', { duration: 2500, }).afterDismissed().subscribe(() => { });
            this.openLoginDialog();
        }
    }
    toggleCommentInput() {
        if (this.displayCommentInput == true) {
            this.displayCommentInput = false;
        } else {
            this.displayCommentInput = true;
        }
    }
    setupDataStream() {
        this.service.getMediaById(this.myInput.mediaId, this.userId).subscribe(a => {
            this.thisMedia = a;
        });
    }
}
