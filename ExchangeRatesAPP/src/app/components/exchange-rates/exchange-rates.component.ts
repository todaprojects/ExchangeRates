import { Component, OnInit } from '@angular/core';
import { Item } from '../../models/Item';
import { ExchangeRateService } from '../../services/exchange-rate.service';

@Component({
  selector: 'app-exchange-rates',
  templateUrl: './exchange-rates.component.html',
  styleUrls: ['./exchange-rates.component.scss']
})
export class ExchangeRatesComponent implements OnInit {
  items: Item[];

  constructor(private exchangeRateService: ExchangeRateService) {
  }

  ngOnInit(): void {
    this.exchangeRateService.dateObservable.subscribe(date => {
      this.exchangeRateService.getExchangeRates(date).subscribe(exchangeRates => {
        if (exchangeRates != null) {
          this.items = exchangeRates;
        } else {
          alert('Try again: valid date is any between 1993-06-26 and 2014-12-31');
        }
      });
    });
  }
}
