import { NgModule } from "@angular/core";
import { HttpClientModule } from "@angular/common/http";
import { BrowserModule } from "@angular/platform-browser";
import { MatTableModule } from '@angular/material/table';
import { MatButtonModule } from '@angular/material/button';
import { MatFormFieldModule } from '@angular/material/form-field'
import { ReactiveFormsModule } from "@angular/forms";
import { MatInputModule } from '@angular/material/input';
import { MatSelectModule } from '@angular/material/select';
import { FormsModule } from '@angular/forms';
import { MatSortModule } from '@angular/material/sort';
import { MatToolbarModule } from '@angular/material/toolbar';

import { BridgesListComponent } from "./components/bridges-list/bridges-list.component";
import { CityStreetsListComponent } from "./components/city-streets-list/city-streets-list.component";
import { MarketSquaresListComponent } from "./components/market-squares-list/market-squares-list.component";
import { ParksListComponent } from "./components/parks-list/parks-list.component";
import { PathsListComponent } from "./components/paths-list/paths-list.component";
import { CountyStreetsListComponent } from "./components/county-streets-list/county-streets-list.component";

@NgModule({
  declarations: [
    BridgesListComponent,
    CityStreetsListComponent,
    CountyStreetsListComponent,
    MarketSquaresListComponent,
    ParksListComponent,
    PathsListComponent
  ],
  imports: [
    HttpClientModule,
    BrowserModule,
    MatTableModule,
    MatButtonModule,
    MatFormFieldModule,
    ReactiveFormsModule,
    MatInputModule,
    MatSelectModule,
    FormsModule,
    MatSortModule,
    MatToolbarModule
  ],
  exports: []
})
export class UlicModule {

}
