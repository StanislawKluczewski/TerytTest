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

import { VoivodeshipsComponent } from "./components/voivodeships-list/voivodeships-list.component";
import { CountiesListComponent } from './components/counties-list/counties-list.component';
import { CitiesVoivodeshipListComponent } from './components/cities-voivodeship-list/cities-voivodeship-list.component';
import { DeleganciesQuartersListComponent } from './components/delegancies-quarters-list/delegancies-quarters-list.component';
import { CountrySidesListComponent } from './components/countrysides-list/countrysides-list.component';
import { DistrictsListComponent } from './components/districts-list/districts-list.component';

@NgModule({
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
  exports: [
    MatTableModule
  ],
  declarations: [
    VoivodeshipsComponent,
    CountiesListComponent,
    CitiesVoivodeshipListComponent,
    DeleganciesQuartersListComponent,
    CountrySidesListComponent,
    DistrictsListComponent
  ]
})
export class TercModule { }
