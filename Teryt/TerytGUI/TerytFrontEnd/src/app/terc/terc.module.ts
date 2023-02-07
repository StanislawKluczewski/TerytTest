import { NgModule } from "@angular/core";
import { HttpClientModule } from "@angular/common/http";
import { BrowserModule } from "@angular/platform-browser";
import { MatTableModule } from '@angular/material/table';
import { MatButtonModule } from '@angular/material/button';
import { TercListComponent } from "./components/terc-list/terc-list.component";

@NgModule({
  imports: [
    HttpClientModule,
    BrowserModule,
    MatTableModule,
    MatButtonModule
  ],
  exports: [
    MatTableModule
  ],
  declarations: [
    TercListComponent
  ]
})
export class TercModule { }
