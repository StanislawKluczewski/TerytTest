import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { environment } from "src/environments/environment.prod";
import { User } from "./components/models/user.model";
import { HttpHeaders } from "@angular/common/http";

@Injectable({
  providedIn: "root"
})
export class CoreService {

  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  }

  constructor(private http: HttpClient) { }

  logIn(user: any): Observable<void> {
    return this.http.post<void>(environment.authUrl + "/login", user, this.httpOptions);
  }

  logout(): Observable<void> {
    return this.http.post<void>(environment.authUrl + "/logout", null);
  }

  signUp(user: any): Observable<void> {
    return this.http.post<void>(environment.authUrl + "/register", user);
  }
}

