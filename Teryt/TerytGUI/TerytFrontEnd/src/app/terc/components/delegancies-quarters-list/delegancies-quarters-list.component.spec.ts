import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DeleganciesQuartersListComponent } from './delegancies-quarters-list.component';

describe('DeleganciesQuartersListComponent', () => {
  let component: DeleganciesQuartersListComponent;
  let fixture: ComponentFixture<DeleganciesQuartersListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DeleganciesQuartersListComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DeleganciesQuartersListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
