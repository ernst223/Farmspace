import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SearchProductMediaComponent } from './search-product-media.component';

describe('SearchProductMediaComponent', () => {
  let component: SearchProductMediaComponent;
  let fixture: ComponentFixture<SearchProductMediaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SearchProductMediaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SearchProductMediaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
