import { Component, OnInit } from '@angular/core';
import { TempBrandHolder, EntryDto } from 'app/shared/shared.models';
import { environment } from 'environments/environment';
import { SharedService } from 'app/shared/shared.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-search-product',
  templateUrl: './search-product.component.html',
  styleUrls: ['./search-product.component.scss']
})
export class SearchProductComponent implements OnInit {
  myBrands: TempBrandHolder[] = [];
  filterEntryByBrand: EntryDto[] = [];
  noResult = false;
  myInput: EntryDto[];
  searchTerm = '';
  canIdisplay = false;
  connectionstring = environment.imageUrl;
  constructor(private shared: SharedService, private Router: ActivatedRoute, private route: Router) { }

  ngOnInit() {
    this.Router.params.subscribe(a => {
      this.searchTerm = a.term;
      this.setupDataStream();
    });

  }

  setupDataStream(): void {
    this.shared.searchProducts(this.searchTerm).subscribe(a => {
      if( a.length == 0) {
        this.noResult = true;
      } else {
        this.noResult = false;
      }
      this.myInput = a;
      this.setMyBrands();
    });
  }
  setMyBrands(): void {
    this.myInput.forEach(element => {
      if (!this.checkIfAlreadyExist(element.brand)) {
        this.myBrands.push({
          id: element.brandId,
          name: element.brand
        });
      }
    });
    this.canIdisplay = true;
  }
  checkIfAlreadyExist(brandname: any) {
    var found = false;
    for (var i = 0; i < this.myBrands.length; i++) {
      if (this.myBrands[i].name == brandname) {
        found = true;
        break;
      }
    }
    return found;
  }
  getImageConnectionString(image: any): string {
    return this.connectionstring + image;
  }
  getBrandEntries(brandId: any) {
    this.filterEntryByBrand = [];
    let tempResult = this.myInput.filter(O => O.brandId == brandId);

    tempResult.forEach(element => {
      if (!this.chackIfAlreadyExistByRange(element.range, this.filterEntryByBrand)) {
        this.filterEntryByBrand.push(element);
      }
    });
    return this.filterEntryByBrand;
  }
  chackIfAlreadyExistByRange(RangeName: any, myArray: EntryDto[]) {
    var found = false;
    for (var i = 0; i < myArray.length; i++) {
      if (myArray[i].range == RangeName) {
        found = true;
        break;
      }
    }
    return found;
  }
  ChipClicked(value: any){
    this.shared.getEntryRoute(value).subscribe(a => {
      console.log(a);
      this.route.navigate(['/productsAndServices/entry', a.superGroup, a.group, a.subGroup, a.brand, a.productName]);
    });
}
}
