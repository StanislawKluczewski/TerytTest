import { NgModule } from "@angular/core";
import { HomeComponent } from "./components/home/home.component";
import { MatCardModule } from '@angular/material/card';
import { RouterModule } from '@angular/router';
import { CommonModule } from "@angular/common";

@NgModule({
  declarations: [
    HomeComponent
  ],
  imports: [
    MatCardModule,
    RouterModule,
    CommonModule
  ],
  exports: []
})
export class SharedModule { }
