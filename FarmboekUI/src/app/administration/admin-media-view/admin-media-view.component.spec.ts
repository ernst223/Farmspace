import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminMediaViewComponent } from './admin-media-view.component';

describe('AdminMediaViewComponent', () => {
  let component: AdminMediaViewComponent;
  let fixture: ComponentFixture<AdminMediaViewComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AdminMediaViewComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AdminMediaViewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
