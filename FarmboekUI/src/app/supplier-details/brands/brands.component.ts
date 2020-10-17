import { Component, OnInit, Input } from '@angular/core';
import { ViewBrandsDto } from 'app/shared/shared.models';
import { SharedService } from 'app/shared/shared.service';
import { environment } from 'environments/environment';
import { Router } from '@angular/router';

@Component({
  selector: 'app-brands',
  templateUrl: './brands.component.html',
  styleUrls: ['./brands.component.scss']
})
export class BrandsComponent implements OnInit {

    myBrands: ViewBrandsDto[] = [];
    canIdisplay = false;
    connectionstring = environment.imageUrl;
  @Input() myInput: number;
  constructor(private service: SharedService,  private router: Router) { }

  ngOnInit() {
      this.setupDataStream();
      // console.log(this.myInput);
  }
  getImageConnectionString(image: any): string {
    return this.connectionstring + image;
  }
  setupDataStream() {
      this.service.getSupplierBrands(this.myInput).subscribe(a => {
          this.myBrands = a;
          this.canIdisplay = true;
      })
  }
  ChipClicked(id: any) {
    this.router.navigate(['/details/brand', id]);
  }
}
