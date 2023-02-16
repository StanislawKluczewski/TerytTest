import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CitiesPartListComponent } from './cities-part-list.component';

describe('CitiesPartListComponent', () => {
  let component: CitiesPartListComponent;
  let fixture: ComponentFixture<CitiesPartListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CitiesPartListComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CitiesPartListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
