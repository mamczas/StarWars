import { Component, Input } from '@angular/core';
import PeopleDto from '../Dtos/PeopleDto';
import { Router } from '@angular/router';

@Component({
  selector: 'app-card-people',
  templateUrl: './card-people.component.html',
  styleUrls: ['./card-people.component.css']
})

export class CardPeopleComponent {


  @Input()  people: PeopleDto;
  @Input()  readOnly: boolean;
  constructor(private router: Router) { }

  goToplay(id: number) {

    this.router.navigate(['play', id, 'people']);
  }
}
