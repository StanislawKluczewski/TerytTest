import { Component, OnInit } from '@angular/core';
import { UlicService } from '../../ulic.service';

@Component({
  selector: 'app-paths-list',
  templateUrl: './paths-list.component.html',
  styleUrls: ['./paths-list.component.scss']
})
export class PathsListComponent implements OnInit {

  constructor(private ulicService: UlicService) { }

  dataSource!: any;
  displayedColumns: string[] = ['Nazwa', 'Nazwa dodatkowa', 'Cecha', 'Stan na'];

  getAllVoivodeships(): void {
    this.ulicService.getPaths().subscribe(result => {
      this.dataSource = result;
    })
  }

  ngOnInit(): void {
  }

}
