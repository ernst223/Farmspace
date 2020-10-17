import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router, NavigationEnd } from '@angular/router';
import { SharedService } from 'app/shared/shared.service';
import { RouteProblemDto } from 'app/shared/shared.models';

@Component({
  selector: 'app-displayproblembase',
  templateUrl: './displayproblembase.component.html',
  styleUrls: ['./displayproblembase.component.scss']
})
export class DisplayproblembaseComponent implements OnInit {

    routeProblem: RouteProblemDto;
    display = false;
   mySubscription: any;
  constructor(private route: ActivatedRoute, private router: Router, private service: SharedService) {
      
this.router.routeReuseStrategy.shouldReuseRoute = function () {
    return false;
  };
  this.mySubscription = this.router.events.subscribe((event) => {
    if (event instanceof NavigationEnd) {
      // Trick the Router into believing it's last link wasn't previously loaded
      this.router.navigated = false;
    }
  });
   }
   ngOnDestroy() {
    if (this.mySubscription) {
      this.mySubscription.unsubscribe();
    }
  }
  ngOnInit() {
      this.display = false;
      this.route.params.subscribe(a => {
          this.getRouteProblem(a.id);
      })
  }

  getRouteProblem(id: any) {
      this.service.getProblemBase(id).subscribe(a => {
          this.routeProblem = a;
          this.display = true;
      })
  }
  getProblemSolutionResult() {
      return this.routeProblem;
  }
}
