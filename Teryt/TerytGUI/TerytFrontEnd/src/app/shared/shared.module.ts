import { NgModule } from "@angular/core";
import { HomeComponent } from "./components/home/home.component";
import { MatCardModule } from '@angular/material/card';
@NgModule({
  declarations: [
    HomeComponent
  ],
  imports: [
    MatCardModule
  ],
  exports: []
})
export class SharedModule { }
