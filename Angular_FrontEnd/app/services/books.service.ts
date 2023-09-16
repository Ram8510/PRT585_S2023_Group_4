import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Book } from '../models/book.model';

@Injectable({
  providedIn: 'root'
})
export class BooksService {

  baseApiUrl: string = environment.baseApiUrl;

  constructor(private http: HttpClient) { }

  getAllBooks(): Observable<Book[]> {
    return this.http.get<Book[]>('https://localhost:7246/api/Book');
    
  }

  addBook(addBookRequest: Book): Observable<Book> {
    addBookRequest.BookId = '0';
    return this.http.post<Book>(this.baseApiUrl + '/api/Book', addBookRequest);
  }

  getBook(BookId: string): Observable<Book> {
    return this.http.get<Book>(this.baseApiUrl + '/api/Book/' + BookId)
  }

  updateBook(BookId: string, updateBookRequest: Book): Observable<Book> {
    return this.http.put<Book>(this.baseApiUrl + '/api/Book/' + BookId, updateBookRequest);
  }

  deleteBook(BookId: string): Observable<Book> {
    return this.http.delete<Book>(this.baseApiUrl + '/api/Book/' + BookId);
  }
}

