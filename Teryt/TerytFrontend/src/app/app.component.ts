import { Component } from '@angular/core';
import { CoreService } from './core/core.service';
import { BreakpointObserver, Breakpoints } from '@angular/cdk/layout';
import { JwtHelperService } from '@auth0/angular-jwt';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { ResponsiveWidthService } from './shared/responsiveness/responsive-screen-size.service';
import { ResponsiveOrientationTypeDeviceService } from './shared/responsiveness/responsive-orientation-device-type.service';
import { Router } from '@angular/router';

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

  constructor(private coreService: CoreService, private helper: JwtHelperService, private router: Router) {
    this.getEmailOfUser();

  }

  logout(): void {
    const token = localStorage.getItem('token');
    this.selected.value.token = token;
    this.coreService.logout(this.selected.value).subscribe(result => {
      localStorage.removeItem('token');
      window.location.reload();

    });
    this.router.navigateByUrl("/Start")
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
