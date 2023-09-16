import { Component, OnInit } from '@angular/core';
import { Club } from 'src/app/models/club.model';
import { ClubsService } from 'src/app/services/clubs.service';

@Component({
  selector: 'app-clubs-list',
  templateUrl: './clubs-list.component.html',
  styleUrls: ['./clubs-list.component.css']
})
export class ClubsListComponent implements OnInit {


  clubs: Club[] = [];

  constructor(private clubsService: ClubsService){}

  ngOnInit(): void {
    this.clubsService.getAllClubs()
    .subscribe({
      next: (clubs) => {
        this.clubs = clubs;
      },
      error: (response) => {
        console.log(response);
      }
    })
  }

}
