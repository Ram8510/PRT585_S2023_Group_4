import { Component, OnInit } from '@angular/core';
import { Building } from 'src/app/models/building.model';
import { BuildingsService } from 'src/app/services/buildings.service';

@Component({
  selector: 'app-buildings-list',
  templateUrl: './buildings-list.component.html',
  styleUrls: ['./buildings-list.component.css']
})
export class BuildingsListComponent implements OnInit {

  buildings: Building[] = [];

  constructor(private buildingsService: BuildingsService){}

  ngOnInit(): void {
    this.buildingsService.getAllBuildings()
    .subscribe({
      next: (buildings) => {
        this.buildings = buildings;
      },
      error: (response) => {
        console.log(response);
      }
    })
  }

}
