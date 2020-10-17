import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators, FormControl } from '@angular/forms';
import { Router } from '@angular/router';
import { SharedService } from 'app/shared/shared.service';
import { MatSnackBar } from '@angular/material';
import { duration } from 'moment';
import { UserDto, UserDtoWithToken, RootObject, Country, Languages } from 'app/shared/shared.models';
import { count, startWith, map } from 'rxjs/operators';
import { CountriesService } from 'app/shared/countries.service';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.scss']
})
export class SignupComponent implements OnInit {
  
  loginForm: FormGroup;
  isLoading = false;
  theUser: UserDtoWithToken;
  tempUser: UserDto;

  tempMyCountries: RootObject;
  myCountries: Country[];
  allLanguages: Languages[];
  selectedLanguages: any;
  selectedLanguagesToAdd: number[] = [];
  filteredOptions: Observable<Country[]>;
  myControl: FormControl = new FormControl();
  selectedCountry: Country;
  constructor(public snackBar: MatSnackBar, private formBuilder: FormBuilder, private router: Router,
              private service: SharedService, private countryService: CountriesService) {
      this.loginForm = this.formBuilder.group({
        Name: ['', Validators.required],
        LastName: ['', Validators.required],
        Email: ['', Validators.required],
        CEmail: ['', Validators.required],
        Id: ['', Validators.required],
        Cell: ['', Validators.required],
        password: ['', Validators.required],
        ConfirmPassword: ['', Validators.required]
      });
     }

  ngOnInit() {
    this.setupDataStream();
    this.tempMyCountries = this.countryService.getCountries();
    this.myCountries = this.tempMyCountries.countries;
    this.filteredOptions = this.myControl.valueChanges
    .pipe(
      startWith(''),
      map(value => this._filter(value))
    );
  }

  setupDataStream(): void {
    this.service.getLanguages().subscribe(a => {
      this.allLanguages = a;
    });
  }
  
  private _filter(value: string): Country[] {
    if (value != null) {
      if ((typeof value) === 'string') {
        const filterValue = value.toLowerCase();
        return this.myCountries.filter(option => option.name.toLowerCase().includes(filterValue));
      }
    } else {
      return this.myCountries;
    }
  }

  countrySelected(option: any) {
    this.selectedCountry = option.option.value;
    // console.log('you selected: ' + this.selectedCountry.name);
  }
  displayData(data?: Country): string | undefined {
    return data ? data.name : undefined;
  }
  compareFn(user1: Languages, user2: Languages) {
    return user1 && user2 ? user1.id === user2.id : user1 === user2;
  }
  register() {
    this.selectedLanguagesToAdd = [];
    this.selectedLanguages.forEach(element => {
      this.selectedLanguagesToAdd.push(element.id);
    });
    if (this.selectedCountry === undefined){
      this.snackBar.open('Please select a Country', 'Close',{ duration: 3000, }).afterDismissed().subscribe(() => {});
    }else{
    
    this.isLoading = true;
    const formModel = this.loginForm.value;
    if (formModel.Email !== formModel.CEmail) {
      this.snackBar.open('Email do not match', '', { duration: 2000, }).afterDismissed().subscribe(() => {});
      return;
    }else{
      this.tempUser = {
        userName: formModel.Email,
        firstName: formModel.Name,
        lastName: formModel.LastName,
        email: formModel.Email,
        idNumber: formModel.Id,
        password: formModel.password,
        cellNumber: formModel.Cell,
        role: 'normal',
        country: this.selectedCountry.name,
        languages: this.selectedLanguagesToAdd};
      if (formModel.password === formModel.ConfirmPassword){
        this.service.register(this.tempUser).subscribe(a => {
          this.theUser = a;
          // console.log(a);
          localStorage.setItem('access_token', this.theUser.token);
          localStorage.setItem('role', this.theUser.role);
          localStorage.setItem('firstname', this.theUser.firstName);
          localStorage.setItem('lastname', this.theUser.lastName);
          localStorage.setItem('id', this.theUser.id);
          this.snackBar.open('Welcome ' + this.theUser.firstName, '',{ duration: 4500, }).afterDismissed().subscribe(() => {});
          this.router.navigate(['/home/media']);
        });
      }else{
        this.isLoading = false;
        this.snackBar.open('Passwords do not match', '', { duration: 2000, }).afterDismissed().subscribe(() => {});
        return;
      }
    }
   }
  }

}
