import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Professor } from '../models/professor.model';

@Injectable({
  providedIn: 'root'
})
export class ProfessorsService {

  baseApiUrl: string = environment.baseApiUrl;

  constructor(private http: HttpClient) { }

  getAllProfessors(): Observable<Professor[]> {
    return this.http.get<Professor[]>('https://localhost:7246/api/Professor');
    
  }

  addProfessor(addProfessorRequest: Professor): Observable<Professor> {
    addProfessorRequest.ProfessorId = '0';
    return this.http.post<Professor>(this.baseApiUrl + '/api/Professor', addProfessorRequest);
  }

  getProfessor(ProfessorId: string): Observable<Professor> {
    return this.http.get<Professor>(this.baseApiUrl + '/api/Professor/' + ProfessorId)
  }

  updateProfessor(ProfessorId: string, updateProfessorRequest: Professor): Observable<Professor> {
    return this.http.put<Professor>(this.baseApiUrl + '/api/Professor/' + ProfessorId, updateProfessorRequest);
  }

  deleteProfessor(ProfessorId: string): Observable<Professor> {
    return this.http.delete<Professor>(this.baseApiUrl + '/api/Professor/' + ProfessorId);
  }
}
