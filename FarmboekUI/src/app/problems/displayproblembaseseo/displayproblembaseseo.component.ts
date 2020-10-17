import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { SharedService } from 'app/shared/shared.service';
import { RouteProblemDto } from 'app/shared/shared.models';

@Component({
  selector: 'app-displayproblembaseseo',
  templateUrl: './displayproblembaseseo.component.html',
  styleUrls: ['./displayproblembaseseo.component.scss']
})
export class DisplayproblembaseseoComponent implements OnInit {

  supergroup = '';
  group = '';
  subgroup = '';
  problemname = '';
  routeProblem: RouteProblemDto;
  display = false;
 

  constructor(private route: ActivatedRoute, private service: SharedService, private router: Router) { }

  ngOnInit() {
    let re = /\_/gi;
    this.route.params.subscribe(a => {
      // console.log(a);
      this.supergroup = a.supergroup.replace(re, ' ');
      this.group = a.group.replace(re, ' ');;
      this.subgroup = a.subgroup.replace(re, ' ');;
      this.problemname = a.problemname.replace(re, ' ');;
      this.setupDataStream();
    });
  }

  setupDataStream() {
    this.service.getProblemBaseSeo(this.supergroup, this.group, this.subgroup, this.problemname).subscribe(a => {
      this.routeProblem = a;
      this.display = true;
    })
  }
  
  getProblemSolutionResult() {
    return this.routeProblem;
  }
}
