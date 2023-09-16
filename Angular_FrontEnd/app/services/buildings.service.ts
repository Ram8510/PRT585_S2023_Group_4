import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Building } from '../models/building.model';

@Injectable({
  providedIn: 'root'
})
export class BuildingsService {

  baseApiUrl: string = environment.baseApiUrl;

  constructor(private http: HttpClient) { }

  getAllBuildings(): Observable<Building[]> {
    return this.http.get<Building[]>('https://localhost:7246/api/Building');
    
  }

  addBuilding(addBuildingRequest: Building): Observable<Building> {
    addBuildingRequest.BuildingId = '0';
    return this.http.post<Building>(this.baseApiUrl + '/api/Building', addBuildingRequest);
  }

  getBuilding(BuildingId: string): Observable<Building> {
    return this.http.get<Building>(this.baseApiUrl + '/api/Building/' + BuildingId)
  }

  updateBuilding(BuildingId: string, updateBuildingRequest: Building): Observable<Building> {
    return this.http.put<Building>(this.baseApiUrl + '/api/Building/' + BuildingId, updateBuildingRequest);
  }

  deleteBuilding(BuildingId: string): Observable<Building> {
    return this.http.delete<Building>(this.baseApiUrl + '/api/Building/' + BuildingId);
  }

}
