import { Component, OnInit } from '@angular/core';
import { LogindialogComponent } from 'app/logindialog/logindialog.component';
import { FuseSidebarService } from '@fuse/components/sidebar/sidebar.service';
import { SharedService } from 'app/shared/shared.service';
import { MatDialog } from '@angular/material';
import { MediaDto } from 'app/shared/shared.models';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.scss']
})
export class SearchComponent implements OnInit {

  searchTerm = '';
  showme = false;
  userId = 0;
  lastId = 0;
  Posts: MediaDto[] = [];
  NextBatch: MediaDto[] = [];

  constructor(private _fuseSidebarService: FuseSidebarService, private shared: SharedService, public dialog: MatDialog,
              private Router: ActivatedRoute, private route: Router) {
  }

  ngOnInit(): void {
    this.Router.params.subscribe(a => {
      this.searchTerm = a.term;
      this.setupDataStream();
    });
  }
  searchMediaProduct(): void {
    this.route.navigate(['home/searchProduct', this.searchTerm]);
  }
  openLoginDialog(): void {
      const dialogRef = this.dialog.open(LogindialogComponent);
      dialogRef.afterClosed().subscribe(result => {

      });
  }
  
  toggleSidebar(name): void {
      this._fuseSidebarService.getSidebar(name).toggleOpen();
  }

  setupDataStream(): void {
      this.shared.searchMedia(this.searchTerm).subscribe(a => {
          if (a.length === 0){
            this.route.navigate(['home/media']);
          }else{
            this.Posts = a;
            this.lastId = this.Posts[this.Posts.length - 1].mediaId;
            this.showme = true;
          }
      });
  }
    shuffleArray(array): any {
      return array.sort(() => Math.random() - 0.5);
    }
}
