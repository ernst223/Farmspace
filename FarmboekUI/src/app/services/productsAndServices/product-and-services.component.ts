import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
import { DummyProblems, Problems, FinalProblem, SuperGroups, Groups, SubGroups, RouteProblemDto, EntryDto } from 'app/shared/shared.models';
import { FormGroup, FormBuilder, FormArray, FormControl, Validators } from '@angular/forms';
import { MatStepper } from '@angular/material';
import { SharedService } from 'app/shared/shared.service';
import { Router, NavigationEnd } from '@angular/router';
import { FuseSidebarService } from '@fuse/components/sidebar/sidebar.service';

@Component({
    selector: 'app-product-and-services',
    templateUrl: './product-and-services.component.html',
    styleUrls: ['./product-and-services.component.scss']
})
export class ProductAndServicesComponent implements OnInit {


    isLinear = false;
    formGroup: FormGroup;
    form: FormArray;
    stepCount = 1;
    Step01Problems: DummyProblems[] = [];
    mySuperGroupResult: Problems[] = [];
    myGroupResult: Problems[] = [];
    mySubGroupResult: Problems[] = [];
    myEntries: EntryDto[] = [];
    SuperGroup: SuperGroups[] = [];
    Group: Groups[] = [];
    SubGroup: SubGroups[] = [];
    RouteProblem: RouteProblemDto[] = [];


    // This variables ate to get the Route Id
    selectedSuperGroup = 0;
    selectedGroup = 0;
    selectedSubGroup = 0;
    selectedRouteProblem = 0;
    selectedRemedie = 0;

    // Display the problems chips
    isRouteProblem = false;

    @ViewChild('stepper', { static: false }) private myStepper: MatStepper;
    @ViewChild('topSection', { static: false }) public contactStructure: ElementRef;
    constructor(private _formBuilder: FormBuilder, private service: SharedService, private _fuseSidebarService: FuseSidebarService, private router: Router) {
        this.router.routeReuseStrategy.shouldReuseRoute = function(){
            return false;
         };
        this.router.events.subscribe((evt) => {
            if (evt instanceof NavigationEnd) {
               // trick the Router into believing it's last link wasn't previously loaded
               this.router.navigated = false;
               // if you need to scroll back to top, here is the right place
               window.scrollTo(0, 0);
            }
        });
    }

    ngOnInit() {
        this.formGroup = this._formBuilder.group({
            form: this._formBuilder.array([this.init()])
        });
        this.setupDataStream();
    }
    setupDataStream() {
        this.service.getSuperGroupsCommercial().subscribe(a => {
            this.SuperGroup = a;
            this.SuperGroup.forEach(element => {
                this.mySuperGroupResult.push({
                    id: element.superGroupId,
                    problem: element.superGroupName
                });
            });
        });
    }

    toggleSidebar(name): void {
        this._fuseSidebarService.getSidebar(name).toggleOpen();
    }

    showResult(index: any): boolean {
        if (index == 4) {
            return true;
        } else {
            return false;
        }
    }
    getStepResult(step: any): any {
        if (step + 1 == 1) {
            return this.mySuperGroupResult;
        } else if (step + 1 == 2) {
            return this.myGroupResult;
        } else if (step + 1 == 3) {
            return this.mySubGroupResult;
        } else if (step + 1 == 4) {
            return this.myEntries;
        }
    }
    getCount(i: any): number {
        return i + 1;
    }

    ChipClicked(value: any) {
        // console.log(value);
        if (this.stepCount === value.count) {
            this.getNextStepResult(value);
            this.addItem();
        } else {
            const tempCount = this.stepCount - value.count;
            for (let i = 0; i < tempCount; i++) {
                this.form.removeAt(this.form.length - 1);
            }
            this.stepCount = this.stepCount - tempCount;
            this.getNextStepResult(value);
            this.addItem();
        }
    }
    AdminChipClicked(value: any) {
        // console.log(value);
        if (value.count == 1) {
            this.service.addSuperGroupCommercial(value.desc).subscribe(a => {
                // Refresh page loading
                this.reloadPage();
            });
        } else if (value.count == 2) {
            this.service.addGroupCommercial(value.desc, this.selectedSuperGroup).subscribe(a => {
                // Refresh page loading
                this.reloadPage();
            });
        } else if (value.count == 3) {
            this.service.addSubGroupCommercial(value.desc, this.selectedSuperGroup, this.selectedGroup).subscribe(a => {
                // Refresh page loading
                this.reloadPage();
            });
        }
    }
    reloadPage() {
        this.router.navigate(['/productsAndServices']);
    }
    getNextStepResult(step: any) {
        // console.log(step);
        if (step.count == 1) {
            this.selectedSuperGroup = step.id;
            this.getGroupResult(step.id);
        } else if (step.count == 2) {
            this.selectedGroup = step.id;
            this.getSubGroupResult( this.selectedSuperGroup, step.id);
        } else if (step.count == 3) {
            this.selectedSubGroup = step.id;
            this.getEntries();
        } else if (step.count == 4) {
            // this.selectedRouteProblem = step.id;
            this.navigateToEntry(step.id);
        }
    }
    navigateToEntry(id: any) {
        const re = /\ /gi;

        this.service.getEntryDetailsforseo(id).subscribe(a => {
            const pSuperGroup = a.supergroup.replace(re, '_');
            const pGroup = a.group.replace(re, '_');
            const pSubGroup = a.subgroup.replace(re, '_');
            const pBrand = a.brand.replace(re, '_');
            const pProductName = a.productName.replace(re, '_');
            this.router.navigate(['/productsAndServices/entry', pSuperGroup, pGroup, pSubGroup, pBrand, pProductName]);
        });
    }
    getIsRoutProblem(index: any): boolean {
        if (index == 3) {
            return this.isRouteProblem;
        } else {
            return false;
        }
    }
    addItem() {
        this.stepCount++;
        this.form = this.formGroup.get('form') as FormArray;
        this.form.push(this.init());
        (async () => {
            // Do something before delay
            // console.log('before delay');

            await this.delay(200);

            // Do something after
            // console.log('after delay');
            this.myStepper.next();
        })();
    }
    delay(ms: number) {
        return new Promise(resolve => setTimeout(resolve, ms));
    }
    getGroupResult(id: any) {
        this.service.getGroupsCommercial(id).subscribe(a => {
            // console.log(a);
            this.Group = a;
            this.myGroupResult = [];
            this.Group.forEach(element => {
                this.myGroupResult.push({
                    id: element.groupId,
                    problem: element.groupName
                });
            });
        });
    }
    getSubGroupResult(supergroupId: any, groupId: any) {
        this.service.getSubGroupsCommercial(supergroupId, groupId).subscribe(a => {
            // console.log(a);
            this.SubGroup = a;
            this.mySubGroupResult = [];
            this.SubGroup.forEach(element => {
                this.mySubGroupResult.push({
                    id: element.subGroupId,
                    problem: element.subGroupName
                });
            });
        });
    }

    getEntries() {
        this.service.getEntries(this.selectedSuperGroup, this.selectedGroup, this.selectedSubGroup).subscribe(a => {
            this.isRouteProblem = true;
            this.myEntries = a;
        });
    }
    init() {
        return this._formBuilder.group({
            cont: new FormControl('', [Validators.required]),
        });
    }

}
