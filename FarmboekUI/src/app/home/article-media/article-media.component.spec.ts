import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ArticleMediaComponent } from './article-media.component';

describe('ArticleMediaComponent', () => {
  let component: ArticleMediaComponent;
  let fixture: ComponentFixture<ArticleMediaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ArticleMediaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ArticleMediaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
