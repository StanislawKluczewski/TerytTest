import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CountrySidesListComponent } from './countrysides-list.component';

describe('CountrySidesListComponent', () => {
  let component: CountrySidesListComponent;
  let fixture: ComponentFixture<CountrySidesListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [CountrySidesListComponent]
    })
      .compileComponents();

    fixture = TestBed.createComponent(CountrySidesListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
