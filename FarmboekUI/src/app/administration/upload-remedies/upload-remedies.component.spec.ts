import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UploadRemediesComponent } from './upload-remedies.component';

describe('UploadRemediesComponent', () => {
  let component: UploadRemediesComponent;
  let fixture: ComponentFixture<UploadRemediesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UploadRemediesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UploadRemediesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
