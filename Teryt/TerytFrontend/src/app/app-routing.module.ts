import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { VoivodeshipsComponent } from './terc/components/voivodeships-list/voivodeships-list.component';
import { CountiesListComponent } from './terc/components/counties-list/counties-list.component';
import { CitiesVoivodeshipListComponent } from './terc/components/cities-voivodeship-list/cities-voivodeship-list.component';
import { DeleganciesQuartersListComponent } from './terc/components/delegancies-quarters-list/delegancies-quarters-list.component';
import { CountrySidesListComponent } from './terc/components/countrysides-list/countrysides-list.component';
import { DistrictsListComponent } from './terc/components/districts-list/districts-list.component';
import { HomeComponent } from './shared/components/home/home.component';
import { CitiestVoivodeshipComponent } from './simc/components/citiest-voivodeship/citiest-voivodeship.component';
import { DeleganciesListComponent } from './simc/components/delegancies-list/delegancies-list.component';
import { TouristicSheltersListComponent } from './simc/components/touristic-shelters-list/touristic-shelters-list.component';
import { SettlementsListComponent } from './simc/components/settlements-list/settlements-list.component';
import { LocalitiesPartsListComponent } from './simc/components/localities-parts-list/localities-parts-list.component';
import { VillagesListComponent } from './simc/components/villages-list/villages-list.component';
import { CitiesPartListComponent } from './simc/components/cities-part-list/cities-part-list.component';
import { WholeVillagesListComponent } from './simc/components/whole-villages-list/whole-villages-list.component';
import { BridgesListComponent } from './ulic/components/bridges-list/bridges-list.component';
import { MarketSquaresListComponent } from './ulic/components/market-squares-list/market-squares-list.component';
import { ParksListComponent } from './ulic/components/parks-list/parks-list.component';
import { PathsListComponent } from './ulic/components/paths-list/paths-list.component';
import { CityStreetsListComponent } from './ulic/components/city-streets-list/city-streets-list.component';
import { CountyStreetsListComponent } from './ulic/components/county-streets-list/county-streets-list.component';
import { LogInComponent } from './core/components/log-in/log-in.component';
import { SignUpComponent } from './core/components/sign-up/sign-up.component';

const routes: Routes = [
  { path: "", component: LogInComponent },
  { path: "Start", component: HomeComponent },
  { path: "Start/Sign-in", component: SignUpComponent },
  { path: "Start/Log-in", component: LogInComponent },
  { path: "TERC/DajWojewodztwa", component: VoivodeshipsComponent },
  { path: "TERC/DajPowiaty", component: CountiesListComponent },
  { path: "TERC/DajMiastaWojewodztwo", component: CitiesVoivodeshipListComponent },
  { path: "TERC/DajDelegaturyDzielnice", component: DeleganciesQuartersListComponent },
  { path: "TERC/DajTerenyWiejskieWPowiecie", component: CountrySidesListComponent },
  { path: "TERC/DajGminy", component: DistrictsListComponent },
  { path: "SIMC/DajMiastaWojewodztwo", component: CitiestVoivodeshipComponent },
  { path: "SIMC/DajDelegaturyMiast", component: DeleganciesListComponent },
  { path: "SIMC/DajSchroniskaTurstyczne", component: TouristicSheltersListComponent },
  { path: "SIMC/DajOsadyWPowiecie", component: SettlementsListComponent },
  { path: "SIMC/DajCzesciMiejscowosci", component: LocalitiesPartsListComponent },
  { path: "SIMC/DajWsieWPowiecie", component: VillagesListComponent },
  { path: "SIMC/DajCzesciMiasta", component: CitiesPartListComponent },
  { path: "SIMC/DajCaleWsie", component: WholeVillagesListComponent },
  { path: "ULIC/DajUliceWPowiecie", component: CountyStreetsListComponent },
  { path: "ULIC/DajRynki", component: MarketSquaresListComponent },
  { path: "ULIC/DajUliceWMiescie", component: CityStreetsListComponent },
  { path: "ULIC/DajMostyWWojewodztwie", component: BridgesListComponent },
  { path: "ULIC/DajParkiWWojewodztwie", component: ParksListComponent },
  { path: "ULIC/DajDrogi", component: PathsListComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
