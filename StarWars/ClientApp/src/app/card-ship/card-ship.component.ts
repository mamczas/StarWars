import { Component, Input } from '@angular/core';
import { Router } from '@angular/router';
import StarsShipDto from '../Dtos/StarsShipDto';

@Component({
  selector: 'app-card-ship',
  templateUrl: './card-ship.component.html',
  styleUrls: ['./card-ship.component.css']
})

export class CardShipComponent {


  @Input()  starsShip: StarsShipDto;
  @Input()  readOnly: boolean;
  constructor(private router: Router) { }

  goToplay(id: number) {
    this.router.navigate(['play', id, 'starsShip']);
  }
}
