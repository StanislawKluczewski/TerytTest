import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { HttpClient } from "@angular/common/http";
import { environment } from "src/environments/environment";
import { TercList } from "./models/terc.model";

@Injectable({
  providedIn: "root"
})
export class TercService {
  constructor(private http: HttpClient) { }

  getAllVoivodeships(): Observable<TercList> {
    return this.http.post<TercList>(environment.url + "TERC/DajWojewodztwa", null);
  }
}
