import { Component, OnInit } from '@angular/core';
import { SharedService } from 'app/shared/shared.service';
import { MediaDto } from 'app/shared/shared.models';
import { MatTableDataSource } from '@angular/material';

@Component({
  selector: 'app-admin-media-view',
  templateUrl: './admin-media-view.component.html',
  styleUrls: ['./admin-media-view.component.scss']
})
export class AdminMediaViewComponent implements OnInit {
  loader = true;
  mediaDate: MediaDto[];
  mediaDataSource: MatTableDataSource<MediaDto> = new MatTableDataSource();
  displayedColumnsMedia = ['id',
    'title',
    'date',
    'actions'];
  constructor(public share: SharedService) { }

  ngOnInit() {
  }

  setupDataStream(): void {

  }
  myIViewThis(): boolean{
    return this.share.isInRole('Admin');
  }
}
