import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FlexableProblemsAndSolutionsComponent } from './flexable-problems-and-solutions.component';

describe('FlexableProblemsAndSolutionsComponent', () => {
  let component: FlexableProblemsAndSolutionsComponent;
  let fixture: ComponentFixture<FlexableProblemsAndSolutionsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FlexableProblemsAndSolutionsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FlexableProblemsAndSolutionsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
