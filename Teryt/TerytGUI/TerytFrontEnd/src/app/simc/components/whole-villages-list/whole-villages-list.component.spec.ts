import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WholeVillagesListComponent } from './whole-villages-list.component';

describe('WholeVillagesListComponent', () => {
  let component: WholeVillagesListComponent;
  let fixture: ComponentFixture<WholeVillagesListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WholeVillagesListComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(WholeVillagesListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
