import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { environment } from "src/environments/environment.prod";
import { UlicList } from "./models/ulic.model";
import { HttpHeaders } from "@angular/common/http";

@Injectable({
  providedIn: "root"
})
export class UlicService {
  constructor(private http: HttpClient) { }

  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  }

  getBridges(object: any): Observable<UlicList> {
    return this.http.post<UlicList>(environment.url + "ULIC/DajMostyWWojewodztwie", object, this.httpOptions);
  }

  getPaths(): Observable<UlicList> {
    return this.http.post<UlicList>(environment.url + "ULIC/DajDrogi", this.httpOptions);
  }

  getMarketSquares(object: any): Observable<UlicList> {
    return this.http.post<UlicList>(environment.url + "ULIC/DajRynki", object, this.httpOptions);
  }

  getParks(object: any): Observable<UlicList> {
    return this.http.post<UlicList>(environment.url + "ULIC/DajParkiWWojewodztwie", object, this.httpOptions);
  }

  getStreetsInCities(object: any): Observable<UlicList> {
    return this.http.post<UlicList>(environment.url + "ULIC/DajUliceWMiescie", object, this.httpOptions);
  }

  getStreetsInCounty(object: any): Observable<UlicList> {
    return this.http.post<UlicList>(environment.url + "ULIC/DajUliceWPowiecie", object, this.httpOptions);
  }

}
