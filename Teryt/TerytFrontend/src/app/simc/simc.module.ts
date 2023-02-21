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

import { CitiestVoivodeshipComponent } from './components/citiest-voivodeship/citiest-voivodeship.component';
import { DeleganciesListComponent } from './components/delegancies-list/delegancies-list.component';
import { TouristicSheltersListComponent } from './components/touristic-shelters-list/touristic-shelters-list.component';
import { LocalitiesPartsListComponent } from './components/localities-parts-list/localities-parts-list.component';
import { SettlementsListComponent } from './components/settlements-list/settlements-list.component';
import { VillagesListComponent } from './components/villages-list/villages-list.component';
import { CitiesPartListComponent } from './components/cities-part-list/cities-part-list.component';
import { WholeVillagesListComponent } from './components/whole-villages-list/whole-villages-list.component';

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
  declarations: [
    CitiestVoivodeshipComponent,
    DeleganciesListComponent,
    TouristicSheltersListComponent,
    LocalitiesPartsListComponent,
    SettlementsListComponent,
    VillagesListComponent,
    CitiesPartListComponent,
    WholeVillagesListComponent
  ],
  exports: []
})
export class SimcModule {

}
