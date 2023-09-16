import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Club } from 'src/app/models/club.model';
import { ClubsService } from 'src/app/services/clubs.service';

@Component({
  selector: 'app-add-club',
  templateUrl: './add-club.component.html',
  styleUrls: ['./add-club.component.css']
})
export class AddClubComponent implements OnInit {



  addClubRequest: Club= {
    ClubId: '',
    ClubName: '',
    ClubLocation: ''
  };

  constructor(private clubService: ClubsService, private router: Router){}
  
  ngOnInit(): void {
      
  }

  addClub(){
    this.clubService.addClub(this.addClubRequest)
    .subscribe({
      next: (club) => {
        this.router.navigate(['clubs']);
      }
    });
  }

}
