import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { environment } from 'environments/environment';
import { BrandDto, TempBrandHolder, EntryDto } from 'app/shared/shared.models';

@Component({
  selector: 'app-flexable-route-entry',
  templateUrl: './flexable-route-entry.component.html',
  styleUrls: ['./flexable-route-entry.component.scss']
})
export class FlexableRouteEntryComponent implements OnInit {

    myBrands: TempBrandHolder[] = [];
    filterEntryByBrand: EntryDto[] = [];
    canIdisplay = false;
    @Input() myInput: EntryDto[];
    @Input() Count: number; 
    @Output() myOutput = new EventEmitter();
    connectionstring = environment.imageUrl;
  constructor() { }

  ngOnInit() {
      this.setMyBrands();
  }

  setMyBrands() {
      this.myInput.forEach(element => {
          if(!this.checkIfAlreadyExist(element.brand)){
              this.myBrands.push({
                  id: element.brandId,
                  name: element.brand
              });
          }
      });
      this.canIdisplay = true;
  }
  getBrandEntries(brandId: any) {
      this.filterEntryByBrand = [];
      let tempResult = this.myInput.filter(O => O.brandId == brandId);
      
      tempResult.forEach(element => {
          if(!this.chackIfAlreadyExistByRange(element.range, this.filterEntryByBrand)) {
              this.filterEntryByBrand.push(element);
          }
      });
      return this.filterEntryByBrand;
  }
  chackIfAlreadyExistByRange(RangeName: any, myArray: EntryDto[]){
    var found = false;
    for(var i = 0; i < myArray.length; i++) {
        if (myArray[i].range == RangeName) {
            found = true;
            break;
        }
    }
    return found;
  }
  checkIfAlreadyExist(brandname: any) {
    var found = false;
    for(var i = 0; i < this.myBrands.length; i++) {
        if (this.myBrands[i].name == brandname) {
            found = true;
            break;
        }
    }
    return found;
  }
  ChipClicked(value: any){
      this.myOutput.emit({id: value, count: this.Count});
  }

  getImageConnectionString(image: any): string {
      return this.connectionstring + image;
  }

}
