import { Component } from '@angular/core';


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
}
