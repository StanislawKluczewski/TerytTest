import { Component, OnInit } from '@angular/core';
import { TercService } from '../../terc.service';
import { HttpHeaders } from '@angular/common/http';
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-counties-list',
  templateUrl: './counties-list.component.html',
  styleUrls: ['./counties-list.component.scss']
})
export class CountiesListComponent implements OnInit {

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

  constructor(private tercService: TercService) { }

  getCounties(): void {
    console.log(this.selectedVoivodeship.value);
    this.tercService.getCountiesInVoivodeship(this.selectedVoivodeship.value).subscribe(result => {
      this.dataSource = result;
    })
  }

  ngOnInit(): void {
  }

}
