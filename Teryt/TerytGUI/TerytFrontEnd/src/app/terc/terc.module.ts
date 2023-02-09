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

import { VoivodeshipsComponent } from "./components/voivodeships-list/voivodeships-list.component";
import { CountiesListComponent } from './components/counties-list/counties-list.component';
import { CitiesVoivodeshipListComponent } from './components/cities-voivodeship-list/cities-voivodeship-list.component';

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
    FormsModule
  ],
  exports: [
    MatTableModule
  ],
  declarations: [
    VoivodeshipsComponent,
    CountiesListComponent,
    CitiesVoivodeshipListComponent
  ]
})
export class TercModule { }
