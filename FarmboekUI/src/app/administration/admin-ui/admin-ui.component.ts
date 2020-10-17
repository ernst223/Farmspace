import { Component, OnInit } from '@angular/core';
import { Route } from '@angular/compiler/src/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-admin-ui',
  templateUrl: './admin-ui.component.html',
  styleUrls: ['./admin-ui.component.scss']
})
export class AdminUiComponent implements OnInit {

  constructor(private router: Router) { }

  ngOnInit() {
  }

  toMediaPost() {
    this.router.navigate(['administration/media-posts']);
  }
  toEntryPost() {
    this.router.navigate(['administration/upload-products']);
  }
  toSolutionPost(){
    this.router.navigate(['administration/upload-solution']);
  }

  toRemedyPost() {
    this.router.navigate(['administration/upload-remedies']);
  }
  toVieMedia() {
    this.router.navigate(['administration/admin-view-media']);
  }
}
