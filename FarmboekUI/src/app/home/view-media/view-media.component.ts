import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { MediaDto } from 'app/shared/shared.models';
import { SharedService } from 'app/shared/shared.service';
import { MatSnackBar, MatDialog } from '@angular/material';
import { LogindialogComponent } from 'app/logindialog/logindialog.component';
import { environment } from 'environments/environment';
import { HttpClient } from '@angular/common/http';
import { Title, Meta } from '@angular/platform-browser';

@Component({
  selector: 'app-view-media',
  templateUrl: './view-media.component.html',
  styleUrls: ['./view-media.component.scss']
})
export class ViewMediaComponent implements OnInit {

  MediaId = 0;
  UserId = 0;
  thisMedia: MediaDto;
  displayMe = false;
  showShare: boolean = false;
  displayCommentInput = false;
  myUrl = 'https://farmspace.co.za/api/socialmedia/share/' ;
  imageUrl = 'https://farmspace.co.za/assets/images/logos/logo_small_farmspace.png';
  htmlToAdd = '';
  myComment = '';
  playerVars = {
    cc_lang_pref: 'en'
  };
  private player;
  private ytEvent;
  connectionstring = environment.apiUrl;
  constructor(private route: ActivatedRoute, private service: SharedService, public snackBar: MatSnackBar,
    public dialog: MatDialog, private httpClient: HttpClient, private titleService: Title, private meta: Meta) { }

  ngOnInit() {
   
    this.route.params.subscribe(a => {
      this.MediaId = a.id;
      this.myUrl += this.MediaId;
      this.meta.updateTag({ name: 'description', content: 'Test onInit change'});
      this.setupDataStream();
      if (this.thisMedia.imageUrl == '' || this.thisMedia.imageUrl == undefined){
        this.imageUrl = 'https://farmspace.co.za/assets/images/logos/logo_small_farmspace.png';
       }else{
        this.imageUrl = this.thisMedia.imageUrl;
       }
    });
  }

  public apiCallbackFn = (route: string) => {
    return this.httpClient.get(route);
}
canShowLink(): boolean {
  if (this.thisMedia.webLink != ''){
      if (this.thisMedia.webLink != undefined){
          return true;
      }else{
          return false;
      }
  }else{
      return false;
  }
}
onStateChange(event) {
  this.ytEvent = event.data;
}
savePlayer(player) {
  this.player = player;
}

ShareClicked() {
  if(this.showShare == true){
      this.showShare = false;
  }else{
      this.showShare = true;
  }
}

playVideo() {
  this.player.playVideo();
}

pauseVideo() {
  this.player.pauseVideo();
}
  getImageUrl(imageUrl: string): string {
    return this.connectionstring + imageUrl;
}
  setupDataStream() {
    this.service.getMediaByIdWithComments(this.MediaId, this.UserId).subscribe(a => {
      this.thisMedia = a;
      this.titleService.setTitle(this.thisMedia.title);
      this.htmlToAdd = this.thisMedia.description;
      this.displayMe = true;
      // console.log(this.thisMedia);
      this.meta.addTag({ name: 'og:description', content: this.thisMedia.title});
      this.meta.addTag({ property: 'og:title', content: this.thisMedia.title});
      if (this.thisMedia.imageUrl) {
        this.meta.addTag({property: 'og:image', content: this.connectionstring + this.thisMedia});
      }
      console.log('Mete data set');
    });
  }

  openLoginDialog(): void {
    const dialogRef = this.dialog.open(LogindialogComponent);
    dialogRef.afterClosed().subscribe(result => {

    });
  }

  likePost() {
    if (this.service.isLoggedIn()) {
      if (this.thisMedia.likeStatus == true) {
        this.service.UnlikePost(this.thisMedia.mediaId, this.UserId).subscribe(a => {
          // console.log('Post Unlike');
          this.setupDataStream();
        });
      } else {
        this.service.likePost(this.thisMedia.mediaId, this.UserId).subscribe(a => {
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

  postComment() {
    if (this.service.isLoggedIn()) {
      this.service.addComment(this.thisMedia.mediaId, this.UserId, this.myComment).subscribe(a => {
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

  IncreaseShareCount() {
        
  }
}
