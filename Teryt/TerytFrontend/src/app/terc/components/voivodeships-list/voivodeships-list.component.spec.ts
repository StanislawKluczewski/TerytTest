import { ComponentFixture, TestBed } from '@angular/core/testing';

import { VoivodeshipsComponent } from './voivodeships-list.component';

describe('VoivodeshipsComponent', () => {
  let component: VoivodeshipsComponent;
  let fixture: ComponentFixture<VoivodeshipsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [VoivodeshipsComponent]
    })
      .compileComponents();

    fixture = TestBed.createComponent(VoivodeshipsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
