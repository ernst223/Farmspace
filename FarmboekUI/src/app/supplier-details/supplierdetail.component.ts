import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'supplierdetail-component',
  template: `
  <div style="width:100%;">
    <router-outlet></router-outlet>
  </div>
  `
})
export class SupplierdetailComponent implements OnInit {

  constructor() { }

  ngOnInit() : void {
  }

}
