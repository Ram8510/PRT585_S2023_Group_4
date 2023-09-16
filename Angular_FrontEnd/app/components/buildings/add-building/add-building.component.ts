import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Building } from 'src/app/models/building.model';
import { BuildingsService } from 'src/app/services/buildings.service';

@Component({
  selector: 'app-add-building',
  templateUrl: './add-building.component.html',
  styleUrls: ['./add-building.component.css']
})
export class AddBuildingComponent implements OnInit {

  addBuildingRequest: Building = {
    BuildingId: '',
    BuildingName: '',
    BuildingDepartment: ''
  };

  constructor(private buildingService: BuildingsService, private router: Router){}
  
  ngOnInit(): void {
      
  }

  addBuilding(){
    this.buildingService.addBuilding(this.addBuildingRequest)
    .subscribe({
      next: (building) => {
        this.router.navigate(['buildings']);
      }
    });
  }

}
