import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TercListComponent } from './terc-list.component';

describe('TercListComponent', () => {
  let component: TercListComponent;
  let fixture: ComponentFixture<TercListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TercListComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TercListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
