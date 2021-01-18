import { TacitsComponent } from './../contents/tacits/tacits.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { StatisticsRoutingModule } from './statistics-routing';



@NgModule({
  declarations: [TacitsComponent],
  imports: [
    CommonModule,
    StatisticsRoutingModule
  ]
})
export class StatisticsModule { }
