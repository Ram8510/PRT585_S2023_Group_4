import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Professor } from 'src/app/models/professor.model';
import { ProfessorsService } from 'src/app/services/professors.service';

@Component({
  selector: 'app-add-professor',
  templateUrl: './add-professor.component.html',
  styleUrls: ['./add-professor.component.css']
})
export class AddProfessorComponent implements OnInit {

  addProfessorRequest: Professor = {
    ProfessorId: '',
    ProfessorName: '',
    ProfessorDepartment: ''
  };

  constructor(private professorService: ProfessorsService, private router: Router){}
  
  ngOnInit(): void {
      
  }

  addProfessor(){
    this.professorService.addProfessor(this.addProfessorRequest)
    .subscribe({
      next: (professor) => {
        this.router.navigate(['professors']);
      }
    });
  }

}
