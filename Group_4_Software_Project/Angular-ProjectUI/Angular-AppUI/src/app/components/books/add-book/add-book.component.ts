import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Book } from 'src/app/model/book.model';
import { BooksService } from 'src/app/services/books.service';


@Component({
  selector: 'app-add-book',
  templateUrl: './add-book.component.html',
  styleUrls: ['./add-book.component.css']
})
export class AddBookComponent implements OnInit {

  addBookRequest: Book = {
    id: '00000000-0000-0000-0000-000000000000',
    title: '',
    author: '',
    publisher: '',
    genre: '',
    author_Email: '',
    published_Year: 0,
    edition: 0,
    language: '',
    price: 0

  };
constructor(private bookService: BooksService, private router: Router) { }


ngOnInit(): void {
  
  }

  addBook() {
    this.bookService.addBook(this.addBookRequest)
    .subscribe({
      next: (book) => {
        this.router.navigate(['books']);
      }
    });
  }
}