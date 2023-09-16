import { Component, OnInit } from '@angular/core';
import { Professor } from 'src/app/models/professor.model';
import { ProfessorsService } from 'src/app/services/professors.service';

@Component({
  selector: 'app-professors-list',
  templateUrl: './professors-list.component.html',
  styleUrls: ['./professors-list.component.css']
})
export class ProfessorsListComponent implements OnInit {

  
  professors: Professor[] = [];

  constructor(private professorsService: ProfessorsService){}

  ngOnInit(): void {
    this.professorsService.getAllProfessors()
    .subscribe({
      next: (professors) => {
        this.professors = professors;
      },
      error: (response) => {
        console.log(response);
      }
    })
  }

}
