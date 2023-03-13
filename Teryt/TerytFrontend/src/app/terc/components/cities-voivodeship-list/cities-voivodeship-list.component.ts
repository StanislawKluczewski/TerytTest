import { Component, OnInit } from '@angular/core';
import { HttpHeaders } from '@angular/common/http';
import { TercService } from '../../terc.service';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-cities-voivodeship-list',
  templateUrl: './cities-voivodeship-list.component.html',
  styleUrls: ['./cities-voivodeship-list.component.scss']
})
export class CitiesVoivodeshipListComponent implements OnInit {

  dataSource!: any;
  displayedColumns: string[] = ['Nazwa', 'Nazwa Terytorialna','Stan na'];
  selectedVoivodeship = new FormGroup({
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

  constructor(private tercService: TercService) {

  }

  getCitiesInVoivodeship(): void {
    this.tercService.getCitiesInVoivdeship(this.selectedVoivodeship.value).subscribe(result => {
      this.dataSource = result;
    })
  }

  ngOnInit(): void {
  }
}
