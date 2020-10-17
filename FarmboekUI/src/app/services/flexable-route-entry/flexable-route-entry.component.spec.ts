import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FlexableRouteEntryComponent } from './flexable-route-entry.component';

describe('FlexableRouteEntryComponent', () => {
  let component: FlexableRouteEntryComponent;
  let fixture: ComponentFixture<FlexableRouteEntryComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FlexableRouteEntryComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FlexableRouteEntryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
