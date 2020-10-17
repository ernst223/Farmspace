import { Component, OnInit } from '@angular/core';
import { Subject, Observable } from 'rxjs';
import { FuseConfigService } from '@fuse/services/config.service';
import { takeUntil, startWith, map } from 'rxjs/operators';
import { FormControl, Validators, FormGroup } from '@angular/forms';
import { SharedService } from 'app/shared/shared.service';
import { Groups, SocialMediaDto, MediaCatagoriesDto, ProductBaseDto, EntryDto, MediaProductLinkDto, MediaRemediesLinkDto, BrandDto, Languages } from 'app/shared/shared.models';
import { MatSnackBar } from '@angular/material';
import { Router } from '@angular/router';

@Component({
  selector: 'app-media-posts',
  templateUrl: './media-posts.component.html',
  styleUrls: ['./media-posts.component.scss']
})
export class MediaPostsComponent implements OnInit {

  fuseConfig: any;
  post: string;
  form: FormGroup;
  private _unsubscribeAll: Subject<any>;
  Title = '';
  CatagoryId = 0;
  WebLink = '';
  YoutubeLink = '';
  Categories: Groups[] = [];
  SelectedCategories: Groups[] = [];
  SelectedRemedies: ProductBaseDto[] = [];
  SelectedProducts: EntryDto[] = [];
  selectedRemedy: string;
  selectedRemedyObject: ProductBaseDto;
  selectedProduct: string;
  selectedProductObject: EntryDto;
  selectedBrand: string;
  selectedBrandObject: BrandDto;
  selectedCategory: string;
  selectedCategoryObject: Groups;
  filteredOptions: Observable<Groups[]>;
  hideImage = false;
  filteredOptionsRemedies: Observable<ProductBaseDto[]>;
  filteredOptionsBrand: Observable<BrandDto[]>;
  filteredOptionsProducts: Observable<EntryDto[]>;
  myControl: FormControl = new FormControl();
  myControlRemedies: FormControl = new FormControl();
  myControlBrand: FormControl = new FormControl();
  myControlProducts: FormControl = new FormControl();
  uploadImageLabel = '(Optional) Choose Image';
  theFile: any;
  fileName: any;
  myFile: any;
  allRemedies: ProductBaseDto[] = [];
  allEntries: EntryDto[] = [];
  allBrands: BrandDto[] = [];
  selectedLanguages: any;
  selectedLanguagesToAdd: number[] = [];
  allLanguages: Languages[];
  myMediaCatagories: MediaCatagoriesDto[] = [];
  myMediaProducts: MediaProductLinkDto[] = [];
  myMediaRemedies: MediaRemediesLinkDto[] = [];
  /**
   * Constructor
   * @param {FuseConfigService} _fuseConfigService
   */
  constructor(
    private _fuseConfigService: FuseConfigService, private shared: SharedService, private _snackBar: MatSnackBar,
    private router: Router
  ) {
    this._unsubscribeAll = new Subject();
  }

  link = new FormControl('');
  youtubeLink = new FormControl('');

  ngOnInit() {
    this._fuseConfigService.config
      .pipe(takeUntil(this._unsubscribeAll))
      .subscribe((config) => {
        this.fuseConfig = config;
      });
    this.getCatagories();
    this.getBrands();
    this.shared.getLanguages().subscribe(a => {
      this.allLanguages = a;
    });
  }

  getCatagories() {
    this.shared.getCatagories().subscribe(a => {
      this.Categories = a;
      // console.log(this.Categories);
      this.filteredOptions = this.myControl.valueChanges
        .pipe(
          startWith(''),
          map(value => this._filter(value))
        );
    });
  }
  getRemedies(brandid: number) {
    this.shared.getAllRemedies(brandid).subscribe(a => {
      this.allRemedies = a;
      this.filteredOptionsRemedies = this.myControlRemedies.valueChanges
        .pipe(
          startWith(''),
          map(value => this._filterRemedies(value))
        );
    });
  }
  getBrands() {
    this.shared.getAllBrands().subscribe(a => {
      this.allBrands = a;
      this.filteredOptionsBrand = this.myControlBrand.valueChanges
        .pipe(
          startWith(''),
          map(value => this._filterBrands(value))
        )
    });
  }
  getProducts(brandid: number) {
    this.shared.getAllEntries(brandid).subscribe(a => {
      this.allEntries = a;
      this.filteredOptionsProducts = this.myControlProducts.valueChanges
        .pipe(
          startWith(''),
          map(value => this._filterProducts(value))
        );
    });
  }
  deleteFromSelectedCatagories(id: any) {
    var index = this.SelectedCategories.findIndex(x => x.groupId == id);
    this.SelectedCategories.splice(index, 1);
    // console.log(this.SelectedCategories);
    // console.log('Deleted from selected Catagories.');
  }
  deleteFromSelectedRemedies(id: any) {
    var index = this.SelectedRemedies.findIndex(x => x.productBaseId == id);
    this.SelectedRemedies.splice(index, 1);
    // console.log(this.SelectedRemedies);
    // console.log('Deleted from SelectedRemedies.');
  }
  deleteFromSelectedProducts(id: any) {
    var index = this.SelectedProducts.findIndex(x => x.entryId == id);
    this.SelectedProducts.splice(index, 1);
    // console.log(this.SelectedProducts);
    // console.log('Deleted from SelectedProducts.');
  }

  addCatagory() {
    if (this.selectedCategoryObject == undefined) {
      this.openSnackBar('Please select a Category', '');
    } else {
      this.SelectedCategories.push(this.selectedCategoryObject);
    }
  }
  addRemedy() {
    if (this.selectedRemedyObject == undefined) {
      this.openSnackBar('Please select a Remedy', '');
    } else {
      this.SelectedRemedies.push(this.selectedRemedyObject);
    }
  }
  addProduct() {
    if (this.selectedProductObject == undefined) {
      this.openSnackBar('Please select a Product', '');
    } else {
      this.SelectedProducts.push(this.selectedProductObject);
    }
  }
  private _filter(value: string): Groups[] {
    if (value != null) {
      if ((typeof value) === 'string') {
        const filterValue = value.toLowerCase();
        return this.Categories.filter(option => option.groupDesc.toLowerCase().includes(filterValue));
      }
    } else {
      return this.Categories;
    }
  }
  private _filterRemedies(value: string): ProductBaseDto[] {
    if (value != null) {
      if ((typeof value) === 'string') {
        const filterValue = value.toLowerCase();
        return this.allRemedies.filter(option => option.name.toLowerCase().includes(filterValue));
      }
    } else {
      return this.allRemedies;
    }
  }
  private _filterBrands(value: string): BrandDto[] {
    if (value != null) {
      if ((typeof value) === 'string') {
        const filterValue = value.toLowerCase();
        return this.allBrands.filter(option => option.name.toLowerCase().includes(filterValue));
      }
    } else {
      return this.allBrands;
    }
  }
  private _filterProducts(value: string): EntryDto[] {
    if (value != null) {
      if ((typeof value) === 'string') {
        const filterValue = value.toLowerCase();
        return this.allEntries.filter(option => option.name.toLowerCase().includes(filterValue));
      }
    } else {
      return this.allEntries;
    }
  }
  displayData(data?: Groups): string | undefined {
    // console.log(data);
    return data ? data.groupDesc : undefined;
  }
  displayDataRemedy(data?: ProductBaseDto): string | undefined {
    return data ? data.name : undefined;
  }
  displayDataProduct(data?: EntryDto): string | undefined {
    return data ? data.name : undefined;
  }

  displayDataBrand(data?: BrandDto): string | undefined {
    return data ? data.name : undefined;
  }

  categorySelected(option: any) {
    this.selectedCategory = option.option.value;
    this.selectedCategoryObject = option.option.value;
    // console.log('you selected: ' + this.selectedCategoryObject.groupId);
  }
  brandSelected(option: any) {
    this.selectedBrand = option.option.value;
    this.selectedBrandObject = option.option.value;
    this.getRemedies(this.selectedBrandObject.brandId);
    this.getProducts(this.selectedBrandObject.brandId);
  }
  productSelected(option: any) {
    this.selectedProduct = option.option.value;
    this.selectedProductObject = option.option.value;
    // console.log('you selected; ' + this.selectedProductObject.entryId);
  }
  remedySelected(option: any) {
    this.selectedRemedy = option.option.value;
    this.selectedRemedyObject = option.option.value;
    // console.log('you selected; ' + this.selectedRemedyObject.productBaseId);
  }
  compareFn(user1: Languages, user2: Languages) {
    return user1 && user2 ? user1.id === user2.id : user1 === user2;
  }
  // Post new post
  postMedia() {
    const today = new Date();
    if (this.selectedCategoryObject.groupId == undefined) {
      this.openSnackBar('Please choose a Category', 'close');
    } else {
      //setting Catagories Link
      this.SelectedCategories.forEach(element => {
        this.myMediaCatagories.push({ id: 0, mediaId: 0, catagoryId: element.groupId });
      });
      //setting Products Link
      this.SelectedProducts.forEach(element => {
        this.myMediaProducts.push({ id: 0, mediaId: 0, entryId: element.entryId });
      });
      //setting Remedies Link
      this.SelectedRemedies.forEach(element => {
        this.myMediaRemedies.push({ id: 0, mediaId: 0, productBaseId: element.productBaseId });
      });

      this.selectedLanguagesToAdd = [];
      this.selectedLanguages.forEach(element => {
        this.selectedLanguagesToAdd.push(element.id);
      });

      //Creating media data Object
      if (this.selectedBrandObject == undefined) {
        const data: SocialMediaDto = {
          id: 0,
          title: this.Title,
          description: this.post,
          webLink: this.WebLink,
          youtubeLink: this.YoutubeLink,
          mediaDate: today,
          theImage: undefined,
          theImageName: undefined,
          mediaCatagories: this.myMediaCatagories,
          mediaProducts: this.myMediaProducts,
          mediaRemedies: this.myMediaRemedies,
          brandId: 0,
          Languages: this.selectedLanguagesToAdd,
          hideImage: this.hideImage
        };

        this.openSnackBar('Please Wait...', 'close');
        this.postSocialMedia(data, this.theFile, this.fileName);
      } else {
        const data: SocialMediaDto = {
          id: 0,
          title: this.Title,
          description: this.post,
          webLink: this.WebLink,
          youtubeLink: this.YoutubeLink,
          mediaDate: today,
          theImage: undefined,
          theImageName: undefined,
          mediaCatagories: this.myMediaCatagories,
          mediaProducts: this.myMediaProducts,
          mediaRemedies: this.myMediaRemedies,
          brandId: this.selectedBrandObject.brandId,
          Languages: this.selectedLanguagesToAdd,
          hideImage: this.hideImage
        };

        this.openSnackBar('Please Wait...', 'close');
        this.postSocialMedia(data, this.theFile, this.fileName);
      }
    }
  }

  public postSocialMedia(T: SocialMediaDto, theFile: any, fileName: string): any {
    //Converting the File into a Base64 and then send to server as Base64 string
    const reader = new FileReader();
    if (this.theFile == undefined) {
      this.shared.postSocialMediaToServer(T).subscribe(a => {
        // console.log('post completed and here is the result:');
        // console.log(a);
        if (a.result == 'Success') {
          // console.log('Post Successful');
          this.openSnackBar('Post Successful', 'close');
          this.clearForm();
        } else {
          // console.log('Post Failed');
          // console.log('Error Message: ' + a);
          this.openSnackBar('Post Failed', 'close');
        }
      });
    } else {
      reader.readAsDataURL(theFile);
      let result;
      reader.onload = (e) => {
        result = reader.result;
        // console.log(result);
        T.theImage = result;
        T.theImageName = fileName;
        this.shared.postSocialMediaToServer(T).subscribe(a => {
          // console.log('post completed and here is the result:');
          // console.log(a);
          if (a.result == 'Success') {
            // console.log('Post Successful');
            this.openSnackBar('Post Successful', 'close');
            this.clearForm();
          } else {
            // console.log('Post Failed');
            // console.log('Error Message: ' + a);
            this.openSnackBar('Post Failed', 'close');
          }
        });
      }
    }
  }

  myIViewThis(): boolean {
    return this.shared.isInRole('Admin');
  }

  OpenImage(event: any) {
    // The file is in this event
    // console.log(event.target.files[0].name);
    this.uploadImageLabel = event.target.files[0].name;
    this.theFile = event.target.files[0];
    this.fileName = event.target.files[0].name;
    this.openSnackBar('Image Ready For Upload', 'Close');
  }

  openSnackBar(message: string, action: string) {
    this._snackBar.open(message, action, {
      duration: 2000,
    });
  }
  // Clear form data and variable data
  clearForm() {
    this.post = '';
    this.Title = '';
    this.WebLink = '';
    this.YoutubeLink = '';
    this.selectedCategory = '';
    this.selectedCategoryObject = undefined;
    this.selectedProduct = '';
    this.selectedProductObject = undefined;
    this.selectedRemedy = '';
    this.selectedRemedyObject = undefined;
    this.SelectedCategories = [];
    this.SelectedProducts = [];
    this.SelectedRemedies = [];
    this.theFile = undefined;
    this.fileName = undefined;
    this.uploadImageLabel = '(Optional) Choose Image';

    this.router.navigate(['/administration/media-posts'])
  }
}

