import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Borrow } from 'src/app/models/borrow.model';
import { BorrowsService } from 'src/app/services/borrows.service';

@Component({
  selector: 'app-add-borrow',
  templateUrl: './add-borrow.component.html',
  styleUrls: ['./add-borrow.component.css']
})
export class AddBorrowComponent implements OnInit {

  addBorrowRequest: Borrow = {
    BorrowId: '',
    BorrowName: '',
    BorrowBook: ''
  };

  constructor(private borrowService: BorrowsService, private router: Router){}
  
  ngOnInit(): void {
      
  }

  addBorrow(){
    this.borrowService.addBorrow(this.addBorrowRequest)
    .subscribe({
      next: (borrow) => {
        this.router.navigate(['borrows']);
      }
    });
  }

}
