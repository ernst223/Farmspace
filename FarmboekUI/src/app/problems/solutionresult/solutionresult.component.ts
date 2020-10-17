import { Component, OnInit, ViewChild, Input, Output, EventEmitter, ElementRef } from '@angular/core';
import { NgImageSliderComponent } from 'ng-image-slider';
import { RouteProblemDto, ImageForDisplay, ProductBaseDto } from 'app/shared/shared.models';
import { SharedService } from 'app/shared/shared.service';
import { environment } from 'environments/environment';
import { Router } from '@angular/router';

@Component({
    selector: 'app-solutionresult',
    templateUrl: './solutionresult.component.html',
    styleUrls: ['./solutionresult.component.scss']
})
export class SolutionresultComponent implements OnInit {
    imageNames: string[] = [];
    connectionstring = environment.imageUrl;
    myHeader = 'This is my Header';
    productBase: ProductBaseDto[] = [];
    showRemedies = false;
    @Input() myInput: RouteProblemDto;
    @Output() myOutput = new EventEmitter();
    @ViewChild('nav', { static: false }) slider: NgImageSliderComponent;
    @ViewChild('scrollMe', { static: false }) private myScrollContainer: ElementRef;
    constructor(private service: SharedService, private router: Router) { }

    ngOnInit() {
        this.myHeader = this.myInput.name;
        this.getImages();
    }
    getImageConnectionString(image: any): string {
        return this.connectionstring + image;
    }
    getImages() {
        this.service.getProblemBaseImages(this.myInput.problemBaseId).subscribe(a => {
            // console.log(a);
            a.forEach(element => {
                this.imageNames.push(this.getImageConnectionString(element));
            });
            // console.log(this.imageNames);
        });
    }

    viewRemedies() {
        // this.service.getRemedies(this.myInput.problemBaseId).subscribe(a => {
        //     this.productBase = a;
        //     this.showRemedies = true;
           
        // });
        this.router.navigate(['/problemsAndSolutions/supportedRemedies', this.myInput.problemBaseId]);
    }
    getRemedies() {
        return this.productBase;
    }
    changeShowRemedies() {
        this.showRemedies = false;
    }
    scrollToBottom(): void {
        try{
            (async () => {
                // Do something before delay
                // console.log('before scroll delay');
    
                await this.delay(1000);
    
                // Do something after
                // console.log('after scroll delay');
                this.myScrollContainer.nativeElement.scrollTop = this.myScrollContainer.nativeElement.scrollHeight;
            })();
        }catch(err){
            // console.log(err);
        }
    }
    delay(ms: number) {
      return new Promise(resolve => setTimeout(resolve, ms));
    }
}
