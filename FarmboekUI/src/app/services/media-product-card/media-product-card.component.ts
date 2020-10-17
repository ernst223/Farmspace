import { Component, OnInit, Input } from '@angular/core';
import { LogindialogComponent } from 'app/logindialog/logindialog.component';
import { MediaDto } from 'app/shared/shared.models';
import { environment } from 'environments/environment';
import { SharedService } from 'app/shared/shared.service';
import { MatSnackBar, MatDialog } from '@angular/material';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-media-product-card',
  templateUrl: './media-product-card.component.html',
  styleUrls: ['./media-product-card.component.scss']
})
export class MediaProductCardComponent implements OnInit {

  userId = 0;
  @Input() myInput: MediaDto;
  thisMedia: MediaDto;
  htmlToAdd = '';
  myComment = '';
  connectionstring = environment.apiUrl;
  displayCommentInput = false;
  playerVars = {
    cc_lang_pref: 'en'
  };
  private player;
  private ytEvent;
  constructor(private service: SharedService, public snackBar: MatSnackBar,
      public dialog: MatDialog, private httpClient: HttpClient) { }

  ngOnInit() {
      this.thisMedia = this.myInput;
      this.htmlToAdd = this.myInput.description;
  }

  getImageUrl(imageUrl: string): string {
      return this.connectionstring + imageUrl;
  }

  public apiCallbackFn = (route: string) => {
      return this.httpClient.get(route);
  }


  enableReadMore(): boolean{
      if (+this.thisMedia.commentCount > 2){
          return true;
      }   else {
          return false;
      }
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
