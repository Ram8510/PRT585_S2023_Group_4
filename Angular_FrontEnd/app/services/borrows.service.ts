import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Borrow } from '../models/borrow.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class BorrowsService {

  baseApiUrl: string = environment.baseApiUrl;

  constructor(private http: HttpClient) { }

  getAllBorrows(): Observable<Borrow[]> {
    return this.http.get<Borrow[]>('https://localhost:7246/api/Borrow');
    
  }

  addBorrow(addBorrowRequest: Borrow): Observable<Borrow> {
    addBorrowRequest.BorrowId = '0';
    return this.http.post<Borrow>(this.baseApiUrl + '/api/Borrow', addBorrowRequest);
  }

  getBorrow(BorrowId: string): Observable<Borrow> {
    return this.http.get<Borrow>(this.baseApiUrl + '/api/Borrow/' + BorrowId)
  }

  updateBorrow(BorrowId: string, updateBorrowRequest: Borrow): Observable<Borrow> {
    return this.http.put<Borrow>(this.baseApiUrl + '/api/Borrow/' + BorrowId, updateBorrowRequest);
  }

  deleteBorrow(BorrowId: string): Observable<Borrow> {
    return this.http.delete<Borrow>(this.baseApiUrl + '/api/Borrow/' + BorrowId);
  }
}
