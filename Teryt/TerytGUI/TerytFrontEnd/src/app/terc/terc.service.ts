import { Injectable } from "@angular/core";
import { Observable, retry } from "rxjs";
import { HttpClient } from "@angular/common/http";
import { environment } from "src/environments/environment";
import { TercList } from "./models/terc.model";
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

  getCitiesInVoivdeship(id: any): Observable<TercList> {
    return this.http.post<TercList>(environment.url + "TERC/DajMiastaWojewodztwie", id, this.httpOptions);
  }

  getCountiesInVoivodeship(id: any): Observable<TercList> {
    return this.http.post<TercList>(environment.url + "TERC/DajPowiatyWojewodztwie", id, this.httpOptions);
  }
}
