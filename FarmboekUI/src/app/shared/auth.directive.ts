import { Inject, Directive, ViewContainerRef, ElementRef, Input, Renderer } from '@angular/core';
import { SharedService } from './shared.service';


@Directive({ selector: '[wg-roles]' })

export class AuthDirective {

    constructor( @Inject(ElementRef) _el: ElementRef, public renderer: Renderer,
     private _viewContainer: ViewContainerRef, private service: SharedService) {
        this.domNode = _el.nativeElement;
    }

    @Input() roles: string;
    private domNode: HTMLElement = null;

    ngOnInit() {
        if (!this.service.isInRole(this.roles)) {
            this.domNode.parentElement.removeChild(this.domNode);
        }
    }
}