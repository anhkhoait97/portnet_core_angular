import { SystemsRoutingModule } from './systems-routing.module';
import { TacitsComponent } from './../contents/tacits/tacits.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';



@NgModule({
  declarations: [TacitsComponent],
  imports: [
    CommonModule,
    SystemsRoutingModule
  ]
})
export class SystemsModule { }
