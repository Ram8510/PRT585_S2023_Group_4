import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Building } from 'src/app/models/building.model';
import { BuildingsService } from 'src/app/services/buildings.service';

@Component({
  selector: 'app-edit-building',
  templateUrl: './edit-building.component.html',
  styleUrls: ['./edit-building.component.css']
})
export class EditBuildingComponent implements OnInit {

  buildingDetails: Building = {
    BuildingId: '',
    BuildingName: '',
    BuildingDepartment: ''

  };

  constructor(private route: ActivatedRoute, private buildingService: BuildingsService, private router: Router) {}

  ngOnInit(): void {
    this.route.paramMap.subscribe({
      next: (params) => {
        const BuildingId = params.get('BuildingId');

        if (BuildingId) {
          this.buildingService.getBuilding(BuildingId)
          .subscribe({
            next: (response) => {
              this.buildingDetails = response;
            }
          })
        }
      }
    })
      
  }

  updateBuilding() {
    this.buildingService.updateBuilding(this.buildingDetails.BuildingId, this.buildingDetails)
    .subscribe({
      next: (response) => {
        this.router.navigate(['buildings']);
      }
    });
  }

  deleteBuilding(BuildingId: string) {
    this.buildingService.deleteBuilding(BuildingId)
    .subscribe({
      next: (response) => {
        this.router.navigate(['buildings']);
      }
    });
  }

}
