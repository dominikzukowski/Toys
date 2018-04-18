import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-toys-list',
  templateUrl: './toys-list.component.html',
  styleUrls: ['./toys-list.component.css']
})

export class ToysListComponent implements OnInit {
  products: string[];

  constructor(private httpClient: HttpClient) {
    this.products = [];
  }

  populateProducts() {
    this.getProducts().subscribe((res) => { this.products = res });
  }

  getProducts() {
    const apiUrl = 'http://localhost:53804/api/product';
    let response = this.httpClient.get<string[]>(apiUrl);
    return response;
  }

  ngOnInit() {
    this.populateProducts();
  }

}
