import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ExchangeRateItemComponent } from './exchange-rate-item.component';

describe('ExchangeRateItemComponent', () => {
  let component: ExchangeRateItemComponent;
  let fixture: ComponentFixture<ExchangeRateItemComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ExchangeRateItemComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ExchangeRateItemComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
