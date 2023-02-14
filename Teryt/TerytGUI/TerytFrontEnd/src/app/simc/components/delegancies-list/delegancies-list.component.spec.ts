import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DeleganciesListComponent } from './delegancies-list.component';

describe('DeleganciesListComponent', () => {
  let component: DeleganciesListComponent;
  let fixture: ComponentFixture<DeleganciesListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DeleganciesListComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DeleganciesListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
