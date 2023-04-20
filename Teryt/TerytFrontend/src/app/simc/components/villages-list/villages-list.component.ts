import { Component, OnInit } from '@angular/core';
import { TercService } from 'src/app/terc/terc.service';
import { SimcService } from '../../simc.service';
import { FormGroup, FormControl, Validators } from '@angular/forms';


@Component({
  selector: 'app-villages-list',
  templateUrl: './villages-list.component.html',
  styleUrls: ['./villages-list.component.scss']
})
export class VillagesListComponent implements OnInit {

  dataSource!: any;
  counties!: any;
  displayedColumns: string[] = ['Nazwa', 'RodzGmina', 'RM Numer', 'Stan na'];
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

  constructor(private simcService: SimcService, private tercService: TercService) { }

  getSettlements(): void {
    this.simcService.getVillagesInCounty(this.selected.value).subscribe(result => {
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
