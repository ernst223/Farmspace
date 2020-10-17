import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UploadSolutionComponent } from './upload-solution.component';

describe('UploadSolutionComponent', () => {
  let component: UploadSolutionComponent;
  let fixture: ComponentFixture<UploadSolutionComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UploadSolutionComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UploadSolutionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
