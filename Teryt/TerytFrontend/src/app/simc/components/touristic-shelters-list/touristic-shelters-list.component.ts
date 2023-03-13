import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { SimcService } from '../../simc.service';

@Component({
  selector: 'app-touristic-shelters-list',
  templateUrl: './touristic-shelters-list.component.html',
  styleUrls: ['./touristic-shelters-list.component.scss']
})
export class TouristicSheltersListComponent implements OnInit {

  dataSource!: any;
  displayedColumns: string[] = ['Nazwa', 'RodzGmina', 'RM Numer', 'Stan na'];
  selected = new FormGroup({
    wojewodztwoId: new FormControl('', Validators.required)
  });

  voivodeships = [
    { value: 2, viewValue: 'Dolnośląskie' },
    { value: 8, viewValue: 'Lubuskie' },
    { value: 12, viewValue: 'Małopolskie' },
    { value: 20, viewValue: 'Podlaskie' },
    { value: 24, viewValue: 'Śląskie' },]


  constructor(private simcService: SimcService) { }

  getDeleganciesInVoivodeship(): void {
    this.simcService.getTouristicShelters(this.selected.value).subscribe(result => {
      this.dataSource = result;
    })
  }

  ngOnInit(): void {
  }

}
