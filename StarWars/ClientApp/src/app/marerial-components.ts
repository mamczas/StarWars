import {NgModule} from '@angular/core';
import {MatCardModule} from '@angular/material/card';
import {MatGridListModule} from '@angular/material/grid-list';
import {MatButtonModule} from '@angular/material/button';
import {MatSelectModule} from '@angular/material/select';


@NgModule({
  exports: [
    MatCardModule,
    MatGridListModule,
    MatButtonModule,
    MatSelectModule
  ]
})
export class MaterialModule {}
