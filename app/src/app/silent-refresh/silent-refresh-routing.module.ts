import { SilentRefreshComponent } from './silent-refresh.component';
import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";


const routes: Routes = [
    {
        path: '',
        component: SilentRefreshComponent
    }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class SilentRefreshRoutingModule { }