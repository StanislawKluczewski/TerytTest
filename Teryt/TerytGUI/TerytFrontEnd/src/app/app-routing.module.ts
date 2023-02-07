import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TercListComponent } from './terc/components/terc-list/terc-list.component';

const routes: Routes = [
  { path: "", component: TercListComponent },
  { path: "terc-list", component: TercListComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
