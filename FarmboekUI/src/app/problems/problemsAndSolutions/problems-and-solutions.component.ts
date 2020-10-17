import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
import { FormGroup, FormArray, FormBuilder, FormControl, Validators } from '@angular/forms';
import { MatStepper } from '@angular/material/stepper';
import { DummyProblems, SuperGroups, Groups, SubGroups, Problems, RouteProblemDto, FinalProblem, ProductBaseDto } from 'app/shared/shared.models';
import { SharedService } from 'app/shared/shared.service';
import { Router, NavigationEnd } from '@angular/router';
import { FuseSidebarService } from '@fuse/components/sidebar/sidebar.service';

@Component({
    selector: 'app-problems-and-solutions',
    templateUrl: './problems-and-solutions.component.html',
    styleUrls: ['./problems-and-solutions.component.scss']
})

export class ProblemsAndSolutionsComponent implements OnInit {

    isLinear = false;
    formGroup: FormGroup;
    form: FormArray;
    stepCount = 1;
    Step01Problems: DummyProblems[] = [];
    mySuperGroupResult: Problems[] = [];
    myGroupResult: Problems[] = [];
    mySubGroupResult: Problems[] = [];
    myRouteProblemResult: FinalProblem[] = [];
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
    @ViewChild('scrollMe', { static: false }) private myScrollContainer: ElementRef;

    constructor(private _formBuilder: FormBuilder, private service: SharedService,
                private _fuseSidebarService: FuseSidebarService,  private router: Router) {
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
        this.Step01Problems = this.service.getDummyProblems();
        // console.log(this.Step01Problems);

        this.service.getSuperGroups().subscribe(a => {
            this.SuperGroup = a;
            this.SuperGroup.forEach(element => {
                this.mySuperGroupResult.push({
                    id: element.superGroupId,
                    problem: element.superGroupDesc
                });
            });
        });
    }

    toggleSidebar(name): void {
        this._fuseSidebarService.getSidebar(name).toggleOpen();
    }

    getControls() {
        return (this.form.get('controlName') as FormArray).controls;
    }
    
    getStepResult(step: any): any {
        if (step + 1 == 1) {
            return this.mySuperGroupResult;
        } else if (step + 1 == 2) {
            return this.myGroupResult;
        } else if (step + 1 == 3) {
            return this.mySubGroupResult;
        } else if (step + 1 == 4) {
            return this.myRouteProblemResult;
        }
    }
    getProblemSolutionResult() {
        return this.RouteProblem.find(o => o.problemBaseId === this.selectedRouteProblem);
    }
    init() {
        return this._formBuilder.group({
            cont: new FormControl('', [Validators.required]),
        });
    }
    goBack() {
        this.myStepper.previous();
    }

    goForward(index: any) {
        // console.log(index);
        if (index + 1 === this.stepCount) {
            this.addItem();
        } else {
            this.myStepper.next();
        }
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

    getNextStepResult(step: any) {
        // console.log(step);
        if (step.count == 1) {
            this.selectedSuperGroup = step.id;
            this.getGroupResult(step.id);
        } else if (step.count == 2) {
            this.selectedGroup = step.id;
            this.getSubGroupResult(step.id);
        } else if (step.count == 3) {
            this.selectedSubGroup = step.id;
            this.getRouteProblemResult();
        } else if (step.count == 4) {
            this.selectedRouteProblem = step.id;
        }
    }
    getStepNamingConvention(step: any) {
        // console.log('naming Convention executed');
        if (step.count == 1) {
            return '(' + this.SuperGroup.find(o => o.id == this.selectedSuperGroup).superGroupDesc + ')';
        } else if (step.count == 2) {
            return '(' + this.Group.find(o => o.id == this.selectedGroup).groupDesc + ')';
        } else if (step.count == 3) {
            return '(' + this.SubGroup.find(o => o.id == this.selectedSubGroup).subGroupDesc + ')';
        } else if (step.count == 4) {
            this.selectedRouteProblem = step.id;
            return '(' + this.myRouteProblemResult.find(o => o.id == this.selectedRouteProblem).problem + ')';
        }
    }
    getGroupResult(id: any) {
        this.service.getGroups(id).subscribe(a => {
            // console.log(a);
            this.Group = a;
            this.myGroupResult = [];
            this.Group.forEach(element => {
                this.myGroupResult.push({
                    id: element.groupId,
                    problem: element.groupDesc
                });
            });
        });
    }
    getSubGroupResult(id: any) {
        this.service.getSubGroups(id).subscribe(a => {
            // console.log(a);
            this.SubGroup = a;
            this.mySubGroupResult = [];
            this.SubGroup.forEach(element => {
                this.mySubGroupResult.push({
                    id: element.subGroupId,
                    problem: element.subGroupDesc
                });
            });
        });
    }
    getRouteProblemResult() {
        this.isRouteProblem = true;
        this.service.getProblemsFromRoute(this.selectedSuperGroup, this.selectedGroup, this.selectedSubGroup).subscribe(a => {
            this.RouteProblem = a;
            // console.log(this.RouteProblem);
            this.myRouteProblemResult = [];
            this.RouteProblem.forEach(element => {
                this.myRouteProblemResult.push({
                    id: element.problemBaseId,
                    problem: element.name,
                    imageLink: element.imageLink
                });
            });
        });
    }
    AdminChipClicked(value: any) {
        // console.log(value);
        if (value.count == 1) {
            this.service.addSuperGroupInformation(value.desc).subscribe(a => {
                // Refresh page loading
                this.reloadPage();
            });
        } else if (value.count == 2) {
            this.service.addGroupInformation(value.desc, this.selectedSuperGroup).subscribe(a => {
                // Refresh page loading
                this.reloadPage();
            });
        } else if (value.count == 3) {
            this.service.addSubGroupInformation(value.desc, this.selectedSuperGroup, this.selectedGroup).subscribe(a => {
                // Refresh page loading
                this.reloadPage();
            });
        }
    }
    reloadPage() {
        this.router.navigate(['/problemsAndSolutions']);
    }
    getIsRoutProblem(index: any): boolean {
        if (index == 3) {
            return this.isRouteProblem;
        } else {
            return false;
        }
    }
    showResult(index: any): boolean {
        if (index == 4) {
            return true;
        } else {
            return false;
        }
    }

    scrollToBottom(): void {
        try{
            (async () => {
                // Do something before delay
                // console.log('before scroll delay');
    
                await this.delay(500);
    
                // Do something after
                // console.log('after scroll delay');
                this.myScrollContainer.nativeElement.scrollTop = this.myScrollContainer.nativeElement.scrollHeight;
            })();
        }catch (err){
            // console.log(err);
        }
    }
    getCount(i: any): number {
        return i + 1;
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
            this.scrollToBottom();
        })();
    }
    delay(ms: number) {
        return new Promise(resolve => setTimeout(resolve, ms));
    }
}
