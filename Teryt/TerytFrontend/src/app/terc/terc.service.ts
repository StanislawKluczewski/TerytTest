import { Injectable } from "@angular/core";
import { Observable, retry } from "rxjs";
import { HttpClient } from "@angular/common/http";
import { environment } from "src/environments/environment.prod";
import { TercList, Terc } from "./models/terc.model";
import { HttpHeaders } from "@angular/common/http";

@Injectable({
  providedIn: "root"
})
export class TercService {

  constructor(private http: HttpClient) { }
  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  }
  getAllVoivodeships(): Observable<TercList> {
    return this.http.post<TercList>(environment.url + "TERC/DajWojewodztwa", this.httpOptions);
  }

  getCitiesInVoivdeship(voivodeshipId: any): Observable<TercList> {
    return this.http.post<TercList>(environment.url + "TERC/DajMiastaWojewodztwie", voivodeshipId, this.httpOptions);
  }

  getCountiesInVoivodeship(voivodeshipId: any): Observable<TercList> {
    return this.http.post<TercList>(environment.url + "TERC/DajPowiatyWojewodztwie", voivodeshipId, this.httpOptions);
  }

  getSingleCounty(object: any): Observable<Terc> {
    return this.http.post<Terc>(environment.url + "TERC/DajPowiat", object, this.httpOptions);
  }

  getDeleganciesQuarters(): Observable<TercList> {
    return this.http.post<TercList>(environment.url + "TERC/DajDelegaturyDzielnice", this.httpOptions);
  }

  getCoutrySides(object: any): Observable<TercList> {
    return this.http.post<TercList>(environment.url + "TERC/DajTerenyWiejskieWPowiecie", object, this.httpOptions);
  }

  getDistricts(object: any): Observable<TercList> {
    return this.http.post<TercList>(environment.url + "TERC/DajGminy", object, this.httpOptions);
  }
}
