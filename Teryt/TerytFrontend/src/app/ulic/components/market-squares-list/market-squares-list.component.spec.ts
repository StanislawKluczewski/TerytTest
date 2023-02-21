import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MarketSquaresListComponent } from './market-squares-list.component';

describe('MarketSquaresListComponent', () => {
  let component: MarketSquaresListComponent;
  let fixture: ComponentFixture<MarketSquaresListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MarketSquaresListComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MarketSquaresListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
