import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Book } from 'src/app/models/book.model';
import { BooksService } from 'src/app/services/books.service';

@Component({
  selector: 'app-edit-book',
  templateUrl: './edit-book.component.html',
  styleUrls: ['./edit-book.component.css']
})
export class EditBookComponent implements OnInit {

  bookDetails: Book = {
    BookId: '',
    BookName: '',
    BookCode: ''

  };

  constructor(private route: ActivatedRoute, private bookService: BooksService, private router: Router) {}

  ngOnInit(): void {
    this.route.paramMap.subscribe({
      next: (params) => {
        const BookId = params.get('BookId');

        if (BookId) {
          this.bookService.getBook(BookId)
          .subscribe({
            next: (response) => {
              this.bookDetails = response;
            }
          })
        }
      }
    })
      
  }

  updateBook() {
    this.bookService.updateBook(this.bookDetails.BookId, this.bookDetails)
    .subscribe({
      next: (response) => {
        this.router.navigate(['books']);
      }
    });
  }

  deleteBook(BookId: string) {
    this.bookService.deleteBook(BookId)
    .subscribe({
      next: (response) => {
        this.router.navigate(['books']);
      }
    });
  }

}
