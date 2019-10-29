import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MaterialModule } from './marerial-components';
import { SlimLoadingBarModule } from 'ng2-slim-loading-bar';
import { InfiniteScrollModule } from 'ngx-infinite-scroll';
import { PeopleService } from './services/people/people.service';
import { CardPeopleComponent } from './card-people/card-people.component';
import { GridPageComponent } from './gridPage/gridPage.component';
import { PlayComponent } from './play/play.component';
import { StarsShipService } from './services/starsShip/starsShip.service';
import { CardShipComponent } from './card-ship/card-ship.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    GridPageComponent,
    CardPeopleComponent,
    PlayComponent,
    CardShipComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    MaterialModule,
    SlimLoadingBarModule,
    InfiniteScrollModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'grid', component: GridPageComponent },
      { path: 'play/:id/:type', component: PlayComponent }
    ]),
    BrowserAnimationsModule
  ],
  providers: [
    PeopleService,
    StarsShipService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
