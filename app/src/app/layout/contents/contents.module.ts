import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TacitsComponent } from './tacits/tacits.component';
import { ContentsRoutingModule } from './contents-routing';



@NgModule({
  declarations: [TacitsComponent],
  imports: [
    CommonModule,
    ContentsRoutingModule
  ]
})
export class ContentsModule { }
