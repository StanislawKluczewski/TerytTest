import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { environment } from "src/environments/environment.prod";
import { SimcList } from "./models/simc.model";
import { HttpHeaders } from "@angular/common/http";

@Injectable({
  providedIn: "root"
})
export class SimcService {

  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  }
  constructor(private http: HttpClient) { }

  getCitiesInVoivodeship(object: any): Observable<SimcList> {
    return this.http.post<SimcList>(environment.url + "SIMC/DajMiastaWWojewodztwie", object, this.httpOptions);
  }

  getDeleganciesInVoivodeship(object: any): Observable<SimcList> {
    return this.http.post<SimcList>(environment.url + "SIMC/DajDelegaturyMiast", object, this.httpOptions);
  }

  getTouristicShelters(object: any): Observable<SimcList> {
    return this.http.post<SimcList>(environment.url + "SIMC/DajSchroniskaTurstyczne", object, this.httpOptions);
  }

  getSettlements(object: any): Observable<SimcList> {
    return this.http.post<SimcList>(environment.url + "SIMC/DajOsadyWPowiecie", object, this.httpOptions);
  }

  getPartsOfLocalities(object: any): Observable<SimcList> {
    return this.http.post<SimcList>(environment.url + "SIMC/DajCzesciMiejscowosci", object, this.httpOptions);
  }

  getVillagesInCounty(object: any): Observable<SimcList> {
    return this.http.post<SimcList>(environment.url + "SIMC/DajWsieWPowiecie", object, this.httpOptions);
  }

  getWholeVillages(object: any): Observable<SimcList> {
    return this.http.post<SimcList>(environment.url + "SIMC/DajCaleWsie", object, this.httpOptions);
  }

  getPartOfCities(object: any): Observable<SimcList> {
    return this.http.post<SimcList>(environment.url + "SIMC/DajCzesciMiasta", object, this.httpOptions);
  }
}

