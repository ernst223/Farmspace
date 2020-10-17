import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FlexableCommercialComponentComponent } from './flexable-commercial-component.component';

describe('FlexableCommercialComponentComponent', () => {
  let component: FlexableCommercialComponentComponent;
  let fixture: ComponentFixture<FlexableCommercialComponentComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FlexableCommercialComponentComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FlexableCommercialComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
