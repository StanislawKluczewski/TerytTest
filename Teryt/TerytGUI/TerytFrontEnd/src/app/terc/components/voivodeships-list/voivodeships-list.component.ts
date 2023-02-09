import { Component, OnInit } from '@angular/core';
import { Terc, TercList } from '../../models/terc.model';
import { TercService } from '../../terc.service';
import { HttpHeaders } from '@angular/common/http';

@Component({
  selector: 'app-terc-list',
  templateUrl: './voivodeships-list.component.html',
  styleUrls: ['./voivodeships-list.component.scss']
})
export class VoivodeshipsComponent implements OnInit {

  dataSource!: any;
  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  }
  displayedColumns: string[] = ['Nazwa', 'Nazwa Terytorialna', 'Wojewodztwo ID', 'Stan na'];

  constructor(private tercService: TercService) {
    console.log(this.dataSource);
  }


  getAllVoivodeships(): void {
    this.tercService.getAllVoivodeships().subscribe(result => {
      this.dataSource = result;
      console.log(result);
    })
  }

  ngOnInit(): void {
  }

}
