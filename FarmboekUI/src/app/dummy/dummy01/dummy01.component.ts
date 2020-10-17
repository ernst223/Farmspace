import { Component, OnInit } from '@angular/core';
import {FormBuilder, FormGroup, Validators, FormArray, FormControl} from '@angular/forms';

@Component({
  selector: 'app-dummy01',
  templateUrl: './dummy01.component.html',
  styleUrls: ['./dummy01.component.scss']
})
export class Dummy01Component implements OnInit {
    isLinear = false;
    formGroup: FormGroup;
    form: FormArray;
    constructor(private _formBuilder: FormBuilder) {    
    }
  
    ngOnInit() {
      this.formGroup = this._formBuilder.group({
        form : this._formBuilder.array([this.init()])
      }); 
      this.addItem();
    }
  
    init(){
      return this._formBuilder.group({
        cont : new FormControl('', [Validators.required]),
      });
    }
  
    addItem(){
      this.form = this.formGroup.get('form') as FormArray;
      this.form.push(this.init());
    }

}
