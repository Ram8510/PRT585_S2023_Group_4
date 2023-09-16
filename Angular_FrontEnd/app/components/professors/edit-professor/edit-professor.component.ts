import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Professor } from 'src/app/models/professor.model';
import { ProfessorsService } from 'src/app/services/professors.service';

@Component({
  selector: 'app-edit-professor',
  templateUrl: './edit-professor.component.html',
  styleUrls: ['./edit-professor.component.css']
})
export class EditProfessorComponent implements OnInit {
  
  professorDetails: Professor = {
    ProfessorId: '',
    ProfessorName: '',
    ProfessorDepartment: ''

  };

  constructor(private route: ActivatedRoute, private professorService: ProfessorsService, private router: Router) {}

  ngOnInit(): void {
    this.route.paramMap.subscribe({
      next: (params) => {
        const ProfessorId = params.get('ProfessorId');

        if (ProfessorId) {
          this.professorService.getProfessor(ProfessorId)
          .subscribe({
            next: (response) => {
              this.professorDetails = response;
            }
          })
        }
      }
    })
      
  }

  updateProfessor() {
    this.professorService.updateProfessor(this.professorDetails.ProfessorId, this.professorDetails)
    .subscribe({
      next: (response) => {
        this.router.navigate(['professors']);
      }
    });
  }

  deleteProfessor(ProfessorId: string) {
    this.professorService.deleteProfessor(ProfessorId)
    .subscribe({
      next: (response) => {
        this.router.navigate(['professors']);
      }
    });
  }

}
