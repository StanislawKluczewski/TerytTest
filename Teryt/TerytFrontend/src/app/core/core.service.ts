import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { environment } from "src/environments/environment.prod";
import { HttpHeaders } from "@angular/common/http";

@Injectable({
  providedIn: "root"
})
export class CoreService {

  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  }

  constructor(private http: HttpClient) { }

  logIn(user: any) {
    return this.http.post<string>(environment.authUrl + "/login", user, this.httpOptions);
  }
  logout(user: any) {
    return this.http.post<void>(environment.authUrl + "/logout", user);
  }
  signUp(user: any): Observable<void> {
    return this.http.post<void>(environment.authUrl + "/register", user);
  }
}

