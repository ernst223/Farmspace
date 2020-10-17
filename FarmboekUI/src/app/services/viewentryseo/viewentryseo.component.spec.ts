import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ViewentryseoComponent } from './viewentryseo.component';

describe('ViewentryseoComponent', () => {
  let component: ViewentryseoComponent;
  let fixture: ComponentFixture<ViewentryseoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ViewentryseoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ViewentryseoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
