import { Component, OnInit } from '@angular/core';
import { LogindialogComponent } from 'app/logindialog/logindialog.component';
import { MediaDto } from 'app/shared/shared.models';
import { ActivatedRoute, Router } from '@angular/router';
import { MatDialog } from '@angular/material';
import { SharedService } from 'app/shared/shared.service';
import { FuseSidebarService } from '@fuse/components/sidebar/sidebar.service';

@Component({
  selector: 'app-search-product-media',
  templateUrl: './search-product-media.component.html',
  styleUrls: ['./search-product-media.component.scss']
})
export class SearchProductMediaComponent implements OnInit {

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
  searchMedia(): void {
    this.route.navigate(['home/search', this.searchTerm]);
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
      this.shared.searchProductMedia(this.searchTerm).subscribe(a => {
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
