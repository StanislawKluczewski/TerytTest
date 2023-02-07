import { Component, OnInit } from '@angular/core';
import { Terc } from '../../models/terc.model';
import { TercService } from '../../terc.service';

@Component({
  selector: 'app-terc-list',
  templateUrl: './terc-list.component.html',
  styleUrls: ['./terc-list.component.scss']
})
export class TercListComponent implements OnInit {

  dataSource: Terc[] = [];
  displayedColumns: string[] = ['Nazwa', 'Nazwa Terytorialna'];

  constructor(private tercService: TercService) {
    console.log(this.dataSource);
  }


  getAllVoivodeships(): void {
    this.tercService.getAllVoivodeships().subscribe(result => {
      this.dataSource = result.tercList;
      console.log(result);
    })
  }

  ngOnInit(): void {
  }

}
