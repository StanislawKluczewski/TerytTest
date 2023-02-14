import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CitiestVoivodeshipComponent } from './citiest-voivodeship.component';

describe('CitiestVoivodeshipComponent', () => {
  let component: CitiestVoivodeshipComponent;
  let fixture: ComponentFixture<CitiestVoivodeshipComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CitiestVoivodeshipComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CitiestVoivodeshipComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
