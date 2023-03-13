import { NgModule } from "@angular/core";
import { HomeComponent } from "./components/home/home.component";
import { MatCardModule } from '@angular/material/card';
import { RouterModule } from '@angular/router';

@NgModule({
  declarations: [
    HomeComponent
  ],
  imports: [
    MatCardModule,
    RouterModule
  ],
  exports: []
})
export class SharedModule { }
