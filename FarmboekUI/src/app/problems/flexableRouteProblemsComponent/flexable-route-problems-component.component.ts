import { Component, OnInit, Input, EventEmitter, Output } from '@angular/core';
import { environment } from 'environments/environment';

@Component({
  selector: 'app-flexable-route-problems-component',
  templateUrl: './flexable-route-problems-component.component.html',
  styleUrls: ['./flexable-route-problems-component.component.scss']
})
export class FlexableRouteProblemsComponentComponent implements OnInit {

    @Input() myInput: any[];
    @Input() Count: number; 
    @Output() myOutput = new EventEmitter();
    connectionstring = environment.imageUrl;
  constructor() { }

  ngOnInit() {
  }

  ChipClicked(value: any){
      this.myOutput.emit({id: value, count: this.Count});
  }

  getImageConnectionString(image: any): string {
      return this.connectionstring + image;
  }

}
