import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CitiesVoivodeshipListComponent } from './cities-voivodeship-list.component';

describe('CitiesVoivodeshipListComponent', () => {
  let component: CitiesVoivodeshipListComponent;
  let fixture: ComponentFixture<CitiesVoivodeshipListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CitiesVoivodeshipListComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CitiesVoivodeshipListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
