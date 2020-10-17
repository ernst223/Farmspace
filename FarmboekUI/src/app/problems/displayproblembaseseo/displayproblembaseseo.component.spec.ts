import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DisplayproblembaseseoComponent } from './displayproblembaseseo.component';

describe('DisplayproblembaseseoComponent', () => {
  let component: DisplayproblembaseseoComponent;
  let fixture: ComponentFixture<DisplayproblembaseseoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DisplayproblembaseseoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DisplayproblembaseseoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
