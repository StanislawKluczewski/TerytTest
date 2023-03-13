import { Component, OnInit } from '@angular/core';
import { SimcService } from '../../simc.service';
import { FormGroup, FormControl, Validators } from '@angular/forms';


@Component({
  selector: 'app-citiest-voivodeship',
  templateUrl: './citiest-voivodeship.component.html',
  styleUrls: ['./citiest-voivodeship.component.scss']
})
export class CitiestVoivodeshipComponent implements OnInit {

  dataSource!: any;
  displayedColumns: string[] = ['Nazwa', 'RodzGmina', 'RM Numer', 'Stan na'];
  selected = new FormGroup({
    wojewodztwoId: new FormControl('', Validators.required)
  });

  voivodeships = [
    { value: 2, viewValue: 'Dolnośląskie' },
    { value: 4, viewValue: 'Kujawsko-Pomorskie' },
    { value: 6, viewValue: 'Lubelskie' },
    { value: 8, viewValue: 'Lubuskie' },
    { value: 10, viewValue: 'Łódzkie' },
    { value: 12, viewValue: 'Małopolskie' },
    { value: 14, viewValue: 'Mazowieckie' },
    { value: 16, viewValue: 'Opolskie' },
    { value: 18, viewValue: 'Podkarpackie' },
    { value: 20, viewValue: 'Podlaskie' },
    { value: 22, viewValue: 'Pomorskie' },
    { value: 24, viewValue: 'Śląskie' },
    { value: 26, viewValue: 'Świętokrzyskie' },
    { value: 28, viewValue: 'Warmińsko-Mazurskie' },
    { value: 30, viewValue: 'Wielkopolskie' },
    { value: 32, viewValue: 'Zachodniopomorskie' }]

  constructor(private simcService: SimcService) { }

  getCitiesInVoivodeship(): void {
    this.simcService.getCitiesInVoivodeship(this.selected.value).subscribe(result => {
      this.dataSource = result;
    });
  }

  ngOnInit(): void {
  }

}
