import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { SimcService } from '../../simc.service';
import { TercService } from 'src/app/terc/terc.service';

@Component({
  selector: 'app-whole-villages-list',
  templateUrl: './whole-villages-list.component.html',
  styleUrls: ['./whole-villages-list.component.scss']
})
export class WholeVillagesListComponent implements OnInit {

  dataSource!: any;
  counties!: any;
  boroughs!: any;
  displayedColumns: string[] = ['Nazwa', 'RodzGmina', 'RM Numer', 'Stan na'];
  selected = new FormGroup({
    wojewodztwoId: new FormControl('', Validators.required),
    powiatId: new FormControl('', Validators.required),
    gminaId: new FormControl('', Validators.required)
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

  constructor(private simcService: SimcService, private tercService: TercService) { }

  getWholeVillages(): void {
    this.simcService.getWholeVillages(this.selected.value).subscribe(result => {
      this.dataSource = result;
    })
  }

  showCounties(event: any): void {
    this.selected.value.wojewodztwoId = event;
    this.tercService.getCountiesInVoivodeship(this.selected.value).subscribe(result => {
      this.counties = result;
    })
  }

  showBoroughs(event: any): void {
    this.selected.value.powiatId = event;
    this.tercService.getDistricts(this.selected.value).subscribe(result => {
      this.boroughs = result;
    })
  }

  ngOnInit(): void {
  }

}
