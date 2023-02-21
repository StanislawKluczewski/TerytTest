import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BridgesListComponent } from './bridges-list.component';

describe('BridgesListComponent', () => {
  let component: BridgesListComponent;
  let fixture: ComponentFixture<BridgesListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BridgesListComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(BridgesListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
