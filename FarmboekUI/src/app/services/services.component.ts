import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'services-component',
  template: `
  <div style="width:100%;">
    <router-outlet></router-outlet>
  </div>
  `
})
export class ServicesComponent implements OnInit {

  constructor() { }

  ngOnInit() : void {
  }

}
