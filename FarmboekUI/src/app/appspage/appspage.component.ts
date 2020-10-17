import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-appspage',
  template: `
  <div style="width:100%;">
    <router-outlet></router-outlet>
  </div>
  `
})
export class AppspageComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

}
