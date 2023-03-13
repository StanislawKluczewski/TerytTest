import { Component, OnInit } from '@angular/core';
import { TercService } from '../../terc.service';

@Component({
  selector: 'app-delegancies-quarters-list',
  templateUrl: './delegancies-quarters-list.component.html',
  styleUrls: ['./delegancies-quarters-list.component.scss']
})
export class DeleganciesQuartersListComponent implements OnInit {

  dataSource!: any;
  displayedColumns: string[] = ['Nazwa', 'Nazwa Terytorialna', 'Stan na'];

  constructor(private tercService: TercService) { }

  ngOnInit(): void {
  }

  getDeleganciesQuarters(): void {
    this.tercService.getDeleganciesQuarters().subscribe(result => {
      this.dataSource = result
    })
  }

}
