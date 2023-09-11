import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Book } from 'src/app/model/book.model';
import { BooksService } from 'src/app/services/books.service';

@Component({
  selector: 'app-edit-book',
  templateUrl: './edit-book.component.html',
  styleUrls: ['./edit-book.component.css']
})
export class EditBookComponent implements OnInit{

  bookDetails: Book = {
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

  constructor(private route: ActivatedRoute, private bookService: BooksService, private router: Router) {}

  ngOnInit(): void {
    this.route.paramMap.subscribe({
      next: (params) => {
        const id = params.get('id');
        console.log('ID:', id);

        if (id) {
          this.bookService.getBook(id)
          .subscribe({
            next: (response) => {
              this.bookDetails = response;
              console.log('Book details:', this.bookDetails);

            },
            error: (error) => {
              console.error('Error:', error);
          }

        });
      }
    }
  })

  }

  updateBook() {
    this.bookService.updateBook(this.bookDetails.id, this.bookDetails)
    .subscribe({
      next: (response) => {
        this.router.navigate(['books']);
      }
    });

   }

  deleteBook(id: string) {
    this.bookService.deleteBook(id)
    .subscribe({
      next: (response) => {
        this.router.navigate(['books']);
      }
    })
  }  
}
  
