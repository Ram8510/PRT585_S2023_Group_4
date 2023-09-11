import { Component, OnInit } from '@angular/core';
import { Book } from 'src/app/model/book.model';
import { BooksService } from 'src/app/services/books.service';


@Component({
  selector: 'app-book-list',
  templateUrl: './book-list.component.html',
  styleUrls: ['./book-list.component.css']
})
export class BookListComponent implements OnInit{
  books: Book[] = [];
  constructor(private bookServices: BooksService) { }

  ngOnInit(): void {
    this.bookServices.getAllBooks()
    .subscribe({
      next: (books) => {
        this.books = books; 
      },
      error: (response) =>{
        console.log(response);
      }
    })


  }

}
