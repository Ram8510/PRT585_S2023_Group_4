import { Component, OnInit } from '@angular/core';
import { Borrow } from 'src/app/models/borrow.model';
import { BorrowsService } from 'src/app/services/borrows.service';

@Component({
  selector: 'app-borrows-list',
  templateUrl: './borrows-list.component.html',
  styleUrls: ['./borrows-list.component.css']
})
export class BorrowsListComponent implements OnInit {

  borrows: Borrow[] = [];

  constructor(private borrowsService: BorrowsService){}

  ngOnInit(): void {
    this.borrowsService.getAllBorrows()
    .subscribe({
      next: (borrows) => {
        this.borrows = borrows;
      },
      error: (response) => {
        console.log(response);
      }
    })
  }

}
