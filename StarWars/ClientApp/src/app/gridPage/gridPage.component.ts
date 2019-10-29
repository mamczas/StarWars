import { Component, OnInit } from '@angular/core';
import { PeopleService } from '../services/people/people.service';
import PeopleDto from '../Dtos/PeopleDto';
import { Observable } from 'rxjs';
import { shareReplay } from 'rxjs/operators';
import { StarsShipService } from '../services/starsShip/starsShip.service';

@Component({
  selector: 'app-grid-page-component',
  templateUrl: './gridPage.component.html',
  styleUrls: ['./gridPage.component.css']
})

export class GridPageComponent {

  public MaxPage = 0;
  public PageIndex = 0;
  public page$: Observable<any>;
  public selectedValue: string;
  private readonly ItemPerPage: number = 6;
  constructor(private ps: PeopleService, private st: StarsShipService) {
   }

   nextPage() {
    this.PageIndex++;
    this.fetchDataFroPage(this.PageIndex);
   }

   previosPage() {
    this.PageIndex--;
    this.fetchDataFroPage(this.PageIndex);
   }


   onSelection() {
    this.PageIndex = 1;

    this.fetchDataFroPage(this.PageIndex);
   }

  private fetchDataFroPage(pageIndex: number) {
    if (this.selectedValue === 'people') {
    this.page$ = this.ps.page(pageIndex, this.ItemPerPage).pipe(shareReplay());
    }
    if (this.selectedValue === 'starsShip') {
      this.page$ = this.st.page(pageIndex, this.ItemPerPage).pipe(shareReplay());
    }
  }
}
