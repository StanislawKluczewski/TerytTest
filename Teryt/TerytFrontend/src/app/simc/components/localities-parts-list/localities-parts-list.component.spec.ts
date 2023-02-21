import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LocalitiesPartsListComponent } from './localities-parts-list.component';

describe('LocalitiesPartsListComponent', () => {
  let component: LocalitiesPartsListComponent;
  let fixture: ComponentFixture<LocalitiesPartsListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LocalitiesPartsListComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(LocalitiesPartsListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
