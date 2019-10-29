import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class StarsShipService {

  private baseUrl: string;
  constructor(
    private http: HttpClient,
  ) {
    this.baseUrl = `/StarsShip/`;
  }

  page(pageNumber: number, itemPerPage: number) {
    const params = new HttpParams({
      fromObject: {
        pageIndex: pageNumber.toString(),
        itemPerPage:  itemPerPage.toString(),
      }
    });

    return this.http.get(`${this.baseUrl}page/`, { params });
  }

  get(id: string) {
    const params = new HttpParams({
      fromObject: {
        id
      }
    });

    return this.http.get(`${this.baseUrl}Get/`, { params });
  }

  random() {
    return this.http.get(`${this.baseUrl}Random/`);
  }
}
