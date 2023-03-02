import { Component } from '@angular/core';
import { CoreService } from './core/core.service';
import { JwtHelperService } from '@auth0/angular-jwt';
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'TerytFrontEnd';
  title2: string = "Teryt";
  opened: boolean = false;
  openedTerc: boolean = false;
  openedSimc: boolean = false;
  openedUlic: boolean = false;
  userEmail: string = '';
  userIsLogged: boolean = false;

  selected = new FormGroup({
    token: new FormControl('', Validators.email),
  });

  constructor(private coreService: CoreService, private helper: JwtHelperService) {
    this.getEmailOfUser();
  }

  logout(): void {
    const token = localStorage.getItem('token');
    this.selected.value.token = token;
    this.coreService.logout(this.selected.value).subscribe(result => {
      localStorage.removeItem('token');
      window.location.reload();
    });

  }

  getEmailOfUser(): void {
    const token = localStorage.getItem('token');
    if (token) {
      const decodedToken = this.helper.decodeToken(token);
      this.userEmail = decodedToken.email;
      this.userIsLogged = true;
    } else {
      this.userEmail = '';
      this.userIsLogged = false;
    }
  }
}
