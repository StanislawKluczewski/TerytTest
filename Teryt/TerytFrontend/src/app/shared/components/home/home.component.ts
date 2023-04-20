import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {

  constructor() { }

  isLogged: boolean = false;
  getUserIsLogged(): boolean {
    const token = localStorage.getItem('token');
    if (token) {
      return true;
    } else {
      return false;
    }
  }

  ngOnInit(): void {
    this.isLogged = this.getUserIsLogged();
    console.log(this.isLogged);
  }

}
