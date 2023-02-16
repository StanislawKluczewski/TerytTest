import { Component, OnInit } from '@angular/core';
import { TercService } from '../../terc.service';
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-districts-list',
  templateUrl: './districts-list.component.html',
  styleUrls: ['./districts-list.component.scss']
})
export class DistrictsListComponent implements OnInit {

  dataSource!: any;
  counties!: any;
  displayedColumns: string[] = ['Nazwa', 'Nazwa Terytorialna', 'Powiat ID', 'Wojewodztwo ID', 'Stan na'];
  selected = new FormGroup({
    wojewodztwoId: new FormControl('', Validators.required),
    powiatId: new FormControl('', Validators.required)
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

  getDistricts(): void {
    this.tercService.getDistricts(this.selected.value).subscribe(result => {
      this.dataSource = result;
    })
  }

  showCounties(event: any): void {
    this.selected.value.wojewodztwoId = event;
    this.tercService.getCountiesInVoivodeship(this.selected.value).subscribe(result => {
      this.counties = result;
    })
  }

  ngOnInit(): void {
  }

}
