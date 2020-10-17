import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'dummy-component',
  template: `
  <div style="width:100%;">
    <router-outlet></router-outlet>
  </div>
  `
})
export class DummyComponent implements OnInit {

  constructor() { }

  ngOnInit() : void {
  }

}
