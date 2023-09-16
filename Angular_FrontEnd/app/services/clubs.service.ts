import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Club } from '../models/club.model';

@Injectable({
  providedIn: 'root'
})
export class ClubsService {

  baseApiUrl: string = environment.baseApiUrl;

  constructor(private http: HttpClient) { }

  getAllClubs(): Observable<Club[]> {
    return this.http.get<Club[]>('https://localhost:7246/api/Club');
    
  }

  addClub(addClubRequest: Club): Observable<Club> {
    addClubRequest.ClubId = '0';
    return this.http.post<Club>(this.baseApiUrl + '/api/Club', addClubRequest);
  }

  getClub(ClubId: string): Observable<Club> {
    return this.http.get<Club>(this.baseApiUrl + '/api/Club/' + ClubId)
  }

  updateClub(ClubId: string, updateClubRequest: Club): Observable<Club> {
    return this.http.put<Club>(this.baseApiUrl + '/api/Club/' + ClubId, updateClubRequest);
  }

  deleteClub(ClubId: string): Observable<Club> {
    return this.http.delete<Club>(this.baseApiUrl + '/api/Club/' + ClubId);
  }
}
