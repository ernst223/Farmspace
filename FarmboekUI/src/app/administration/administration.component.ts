import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-administration',
  template: `
  <div style="width:100%;">
    <router-outlet></router-outlet>
  </div>
  `
})
export class AdministrationComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

}
