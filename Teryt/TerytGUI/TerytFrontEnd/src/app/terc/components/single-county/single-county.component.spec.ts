import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SingleCountyComponent } from './single-county.component';

describe('SingleCountyComponent', () => {
  let component: SingleCountyComponent;
  let fixture: ComponentFixture<SingleCountyComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SingleCountyComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SingleCountyComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
