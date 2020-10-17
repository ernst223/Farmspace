import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MediaProductCardComponent } from './media-product-card.component';

describe('MediaProductCardComponent', () => {
  let component: MediaProductCardComponent;
  let fixture: ComponentFixture<MediaProductCardComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MediaProductCardComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MediaProductCardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
