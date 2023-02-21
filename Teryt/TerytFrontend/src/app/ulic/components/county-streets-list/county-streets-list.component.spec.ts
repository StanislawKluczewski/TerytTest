import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CountyStreetsListComponent } from './county-streets-list.component';

describe('CountyStreetsListComponent', () => {
  let component: CountyStreetsListComponent;
  let fixture: ComponentFixture<CountyStreetsListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CountyStreetsListComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CountyStreetsListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
