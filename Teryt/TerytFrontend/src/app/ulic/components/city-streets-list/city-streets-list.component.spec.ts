import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CityStreetsListComponent } from './city-streets-list.component';

describe('CityStreetsListComponent', () => {
  let component: CityStreetsListComponent;
  let fixture: ComponentFixture<CityStreetsListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CityStreetsListComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CityStreetsListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
