import { Component, OnInit } from '@angular/core';
import { SimcService } from '../../simc.service';
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-delegancies-list',
  templateUrl: './delegancies-list.component.html',
  styleUrls: ['./delegancies-list.component.scss']
})
export class DeleganciesListComponent implements OnInit {

  dataSource!: any;
  displayedColumns: string[] = ['Nazwa', 'RodzGmina', 'RM Numer', 'Stan na'];
  selected = new FormGroup({
    wojewodztwoId: new FormControl('', Validators.required)
  });

  voivodeships = [
    { value: 2, viewValue: 'Dolnośląskie' },
    { value: 10, viewValue: 'Łódzkie' },
    { value: 12, viewValue: 'Małopolskie' },
    { value: 30, viewValue: 'Wielkopolskie' }]

  constructor(private simcService: SimcService) { }

  getDeleganciesInVoivodeship(): void {
    this.simcService.getDeleganciesInVoivodeship(this.selected.value).subscribe(result => {
      this.dataSource = result;
    });
  }

  ngOnInit(): void {
  }

}
