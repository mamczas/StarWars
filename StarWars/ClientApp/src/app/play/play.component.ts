import { Component, OnInit, OnDestroy } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Observable, forkJoin  } from 'rxjs';
import { PeopleService } from '../services/people/people.service';
import { StarsShipService } from '../services/starsShip/starsShip.service';
import { getMatScrollStrategyAlreadyAttachedError } from '@angular/cdk/overlay/typings/scroll/scroll-strategy';

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
  public score: number;
    constructor(private route: ActivatedRoute, private ps: PeopleService, private st: StarsShipService) { 
      this.score = 0;
    }

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

    this.sub();
  }

  private sub() {
    forkJoin([this.my$, this.random$]).subscribe(results => {
      if (this.type === 'people') {
        const myMass = results[0].mass;
        const randomMass = results[1].mass;
        this.getScore(myMass, randomMass);
      }
      if (this.type === 'starsShip') {
        const myMass = results[0].cargoCapacity;
        const randomMass = results[1].cargoCapacity;
        this.getScore(myMass, randomMass);
      }
    });
  }

  getScore(my: number, random: number) {
    if (my > random) {
      this.score++;
    } else if (my < random) {
      this.score--;
    }
  }

  playAgain() {
    if (this.type === 'people') {
      this.random$ = this.ps.random();
    }
    if (this.type === 'starsShip') {
      this.random$ = this.st.random();
    }

    this.sub();
  }

}
