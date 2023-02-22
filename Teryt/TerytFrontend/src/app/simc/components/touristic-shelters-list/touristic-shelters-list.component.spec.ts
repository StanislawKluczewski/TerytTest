import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TouristicSheltersListComponent } from './touristic-shelters-list.component';

describe('TouristicSheltersListComponent', () => {
  let component: TouristicSheltersListComponent;
  let fixture: ComponentFixture<TouristicSheltersListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TouristicSheltersListComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TouristicSheltersListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
