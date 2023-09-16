import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Instrument } from '../models/instrument.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class InstrumentsService {

  baseApiUrl: string = environment.baseApiUrl;

  constructor(private http: HttpClient) { }

  getAllInstruments(): Observable<Instrument[]> {
    return this.http.get<Instrument[]>('https://localhost:7246/api/Instrument');
    
  }

  addInstrument(addInstrumentRequest: Instrument): Observable<Instrument> {
    addInstrumentRequest.InstrumentId = '0';
    return this.http.post<Instrument>(this.baseApiUrl + '/api/Instrument', addInstrumentRequest);
  }

  getInstrument(InstrumentId: string): Observable<Instrument> {
    return this.http.get<Instrument>(this.baseApiUrl + '/api/Instrument/' + InstrumentId)
  }

  updateInstrument(InstrumentId: string, updateInstrumentRequest: Instrument): Observable<Instrument> {
    return this.http.put<Instrument>(this.baseApiUrl + '/api/Instrument/' + InstrumentId, updateInstrumentRequest);
  }

  deleteInstrument(InstrumentId: string): Observable<Instrument> {
    return this.http.delete<Instrument>(this.baseApiUrl + '/api/Instrument/' + InstrumentId);
  }






}
