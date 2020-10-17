import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'problems-component',
  template: `
  <div style="width:100%;">
    <router-outlet></router-outlet>
  </div>
  `
})
export class ProblemsComponent implements OnInit {

  constructor() { }

  ngOnInit() : void {
  }

}
