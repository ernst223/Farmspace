import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { Dummy01Component } from './dummy01.component';

describe('Dummy01Component', () => {
  let component: Dummy01Component;
  let fixture: ComponentFixture<Dummy01Component>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ Dummy01Component ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(Dummy01Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
