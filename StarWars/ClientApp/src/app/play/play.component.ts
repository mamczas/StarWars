import { Component, OnInit, OnDestroy } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Observable } from 'rxjs';
import { PeopleService } from '../services/people/people.service';
import { StarsShipService } from '../services/starsShip/starsShip.service';

@Component({
  selector: 'app-play',
  templateUrl: './play.component.html',
  styleUrls: ['./play.component.css']
})
export class PlayComponent implements OnInit {


  private id: string;
  private type: string;
  public my$: Observable<any>;
  public random$: Observable<any>;
    constructor(private route: ActivatedRoute, private ps: PeopleService, private st: StarsShipService) { }

  ngOnInit() {
    this.id = this.route.snapshot.paramMap.get('id');
    this.type = this.route.snapshot.paramMap.get('type');

    if (this.type === 'people') {
      this.my$ = this.ps.get(this.id);
      this.random$ = this.ps.random();
    }
    if (this.type === 'starsShip') {
      this.my$ = this.st.get(this.id);
      this.random$ = this.st.random();
    }
  }



  playAgain() {
    if (this.type === 'people') {
      this.random$ = this.ps.random();
    }
    if (this.type === 'starsShip') {
      this.random$ = this.st.random();
    }
  }

}
