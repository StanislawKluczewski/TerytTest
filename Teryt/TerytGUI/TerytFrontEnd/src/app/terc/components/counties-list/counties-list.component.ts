import { Component, OnInit } from '@angular/core';
import { TercService } from '../../terc.service';
import { HttpHeaders } from '@angular/common/http';

@Component({
  selector: 'app-counties-list',
  templateUrl: './counties-list.component.html',
  styleUrls: ['./counties-list.component.scss']
})
export class CountiesListComponent implements OnInit {

  dataSource!: any;
  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  }
  displayedColumns: string[] = ['Nazwa', 'Nazwa Terytorialna', 'Wojewodztwo ID', 'Stan na'];

  constructor(private tercService: TercService) {
    console.log(this.dataSource);
  }


  getCounties(): void {
    console.log('clicked');
    // this.tercService.getAllVoivodeships().subscribe(result => {
    //   this.dataSource = result;
    //   console.log(result);
    // })
  }

  ngOnInit(): void {
  }

}
