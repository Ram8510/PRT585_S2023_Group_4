import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Club } from 'src/app/models/club.model';
import { ClubsService } from 'src/app/services/clubs.service';

@Component({
  selector: 'app-edit-club',
  templateUrl: './edit-club.component.html',
  styleUrls: ['./edit-club.component.css']
})
export class EditClubComponent implements OnInit {


   clubDetails: Club = {
    ClubId: '',
    ClubName: '',
    ClubLocation: ''

  };

  constructor(private route: ActivatedRoute, private clubService: ClubsService, private router: Router) {}

  ngOnInit(): void {
    this.route.paramMap.subscribe({
      next: (params) => {
        const ClubId = params.get('ClubId');

        if (ClubId) {
          this.clubService.getClub(ClubId)
          .subscribe({
            next: (response) => {
              this.clubDetails = response;
            }
          })
        }
      }
    })
      
  }

  updateClub() {
    this.clubService.updateClub(this.clubDetails.ClubId, this.clubDetails)
    .subscribe({
      next: (response) => {
        this.router.navigate(['clubs']);
      }
    });
  }

  deleteClub(ClubId: string) {
    this.clubService.deleteClub(ClubId)
    .subscribe({
      next: (response) => {
        this.router.navigate(['clubs']);
      }
    });
  }

}
