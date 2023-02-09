import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { VoivodeshipsComponent } from './terc/components/voivodeships-list/voivodeships-list.component';
import { CountiesListComponent } from './terc/components/counties-list/counties-list.component';
import { CitiesVoivodeshipListComponent } from './terc/components/cities-voivodeship-list/cities-voivodeship-list.component';

const routes: Routes = [
  { path: "", component: VoivodeshipsComponent },
  { path: "DajWojewodztwa", component: VoivodeshipsComponent },
  { path: "DajPowiaty", component: CountiesListComponent },
  { path: "DajMiastaWojewodztwo", component: CitiesVoivodeshipListComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
