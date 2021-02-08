import { Component, Input, OnInit } from '@angular/core';
import { Item } from '../../models/Item';

@Component({
  selector: 'app-exchange-rate-item',
  templateUrl: './exchange-rate-item.component.html',
  styleUrls: ['./exchange-rate-item.component.scss']
})
export class ExchangeRateItemComponent implements OnInit {
  @Input() item: Item;

  constructor() { }

  ngOnInit(): void {
  }

}
