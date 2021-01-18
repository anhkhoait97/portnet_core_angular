import { TacitsComponent } from './../contents/tacits/tacits.component';
import { RouterModule, Routes } from "@angular/router";
import { NgModule } from '@angular/core';

const routes: Routes = [
    {
        path: '',
        component: TacitsComponent
    },
    {
        path: 'tacits',
        component: TacitsComponent
    },
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class StatisticsRoutingModule {}