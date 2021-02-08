import { Component, OnInit } from '@angular/core';
import { ExchangeRateService } from '../../services/exchange-rate.service';

@Component({
  selector: 'app-add-date',
  templateUrl: './add-date.component.html',
  styleUrls: ['./add-date.component.scss']
})
export class AddDateComponent implements OnInit {
  date: Date;

  constructor(private exchangeRateService: ExchangeRateService) {
  }

  ngOnInit(): void {
    // set default date value for error handling
    this.exchangeRateService.handleDateSubmit('');
  }

  onSubmit(): void {
    if (this.date !== undefined) {
      this.exchangeRateService.handleDateSubmit(this.date.toString());
    } else {
      alert('date has not been set');
    }
  }
}
