import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BehaviorSubject, Observable } from 'rxjs';
import { Item } from '../models/Item';

@Injectable({
  providedIn: 'root'
})
export class ExchangeRateService {
  private dateBehaviorSubject = new BehaviorSubject(null);
  dateObservable = this.dateBehaviorSubject.asObservable();

  exchangeRatesUrl = 'https://localhost:5001/exchangerates/';

  constructor(private http: HttpClient) {
  }

  // Get Exchange rates
  getExchangeRates(date: string): Observable<Item[]> {
    return this.http.get<Item[]>(`${this.exchangeRatesUrl}${date}`);
  }

  handleDateSubmit(date: string): void {
    this.dateBehaviorSubject.next(date);
  }
}
