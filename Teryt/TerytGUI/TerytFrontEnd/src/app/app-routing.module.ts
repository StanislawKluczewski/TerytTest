import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { VoivodeshipsComponent } from './terc/components/voivodeships-list/voivodeships-list.component';
import { CountiesListComponent } from './terc/components/counties-list/counties-list.component';
import { CitiesVoivodeshipListComponent } from './terc/components/cities-voivodeship-list/cities-voivodeship-list.component';
import { SingleCountyComponent } from './terc/components/single-county/single-county.component';
import { DeleganciesQuartersListComponent } from './terc/components/delegancies-quarters-list/delegancies-quarters-list.component';
import { CountrySidesListComponent } from './terc/components/countrysides-list/countrysides-list.component';
import { DistrictsListComponent } from './terc/components/districts-list/districts-list.component';

const routes: Routes = [
  { path: "", component: VoivodeshipsComponent },
  { path: "DajWojewodztwa", component: VoivodeshipsComponent },
  { path: "DajPowiaty", component: CountiesListComponent },
  { path: "DajMiastaWojewodztwo", component: CitiesVoivodeshipListComponent },
  { path: "DajPowiat", component: SingleCountyComponent },
  { path: "DajDelegaturyDzielnice", component: DeleganciesQuartersListComponent },
  { path: "DajTerenyWiejskieWPowiecie", component: CountrySidesListComponent },
  { path: "DajGminy", component: DistrictsListComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
