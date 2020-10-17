import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { SharedService } from 'app/shared/shared.service';
import { ProductBaseDto, RemedyProblems, ActiveIngredientDto, BrandDto } from 'app/shared/shared.models';
import { environment } from 'environments/environment';

@Component({
  selector: 'app-remedies',
  templateUrl: './remedies.component.html',
  styleUrls: ['./remedies.component.scss']
})
export class RemediesComponent implements OnInit {
  id: number;
  remedyDetails: ProductBaseDto;
  remedyProblems: RemedyProblems[] = [];
  displayRemedyProblems = false;
  myActiveIngredients: ActiveIngredientDto[] = [];
  brand: BrandDto;
  connectionstring = environment.imageUrl;
  constructor(private route: ActivatedRoute, private service: SharedService, private router: Router) { }

  ngOnInit() {
    this.route.params.subscribe(a => {
      this.id = a.id;
    });
    this.getTheRemedy();
  }

  getTheRemedy() {
    this.service.getRemedy(this.id).subscribe(a => {
      this.remedyDetails = a;
      this.getBrand();
      this.getRemedyProblems();
      this.displayRemedyProblems = false;
      this.getActiveIngredient();
      // console.log(this.remedyDetails);
    });
  }
  getImageConnectionString(image: any): string {
    return this.connectionstring + image;
  }
  getBrand() {
    this.service.getBrand(this.remedyDetails.brandId).subscribe(a => {
      this.brand = a;
    });
  }
  getActiveIngredient() {
    this.service.getActiveIngredient(this.remedyDetails.productBaseId).subscribe(a => {
      this.myActiveIngredients = a;
    });
  }
  showActiveIngredient(): boolean {
    if (this.getActiveIngredient.length < 0) {
      return false;
    } else {
      return true;
    }
  }
  getRemedyProblems() {
    this.service.getRemedyProblems(this.remedyDetails.productBaseId).subscribe(a => {
      this.remedyProblems = a;
      this.displayRemedyProblems = true;
    });
  }
  enquire() {
    // console.log('You are enquiring for product id: ' + this.remedyDetails.productBaseId);
    this.router.navigate(['/details/suppliersbybrand', this.remedyDetails.brandId]);
  }
}
