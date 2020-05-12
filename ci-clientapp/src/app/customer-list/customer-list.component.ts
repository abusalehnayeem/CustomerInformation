import { Component, OnInit } from '@angular/core';
import { Customer } from './models/customer';
import { CustomerService } from './shared/customer.service';
import { GridDataResult } from '@progress/kendo-angular-grid';

@Component({
  selector: 'app-customer-list',
  templateUrl: './customer-list.component.html',
  styles: []
})
export class CustomerListComponent implements OnInit {

  allCustomers: Customer[] = [];
  gridView: GridDataResult;

  constructor(private customerService: CustomerService) { }

  ngOnInit(): void {
    this.getCustomers();
  }
  getCustomers() {
    this.customerService.getCustomers().subscribe(data => {
      this.allCustomers = data;
      this.loadCustomers();
    });
  }

  private loadCustomers(): void {
    this.gridView = {
      data: this.allCustomers,
      total: this.allCustomers.length
    };
  }

}
