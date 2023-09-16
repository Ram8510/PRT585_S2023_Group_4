import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Borrow } from 'src/app/models/borrow.model';
import { BorrowsService } from 'src/app/services/borrows.service';

@Component({
  selector: 'app-edit-borrow',
  templateUrl: './edit-borrow.component.html',
  styleUrls: ['./edit-borrow.component.css']
})
export class EditBorrowComponent implements OnInit {


  borrowDetails: Borrow = {
    BorrowId: '',
    BorrowName: '',
    BorrowBook: ''

  };

  constructor(private route: ActivatedRoute, private borrowService: BorrowsService, private router: Router) {}

  ngOnInit(): void {
    this.route.paramMap.subscribe({
      next: (params) => {
        const BorrowId = params.get('BorrowId');

        if (BorrowId) {
          this.borrowService.getBorrow(BorrowId)
          .subscribe({
            next: (response) => {
              this.borrowDetails = response;
            }
          })
        }
      }
    })
      
  }

  updateBorrow() {
    this.borrowService.updateBorrow(this.borrowDetails.BorrowId, this.borrowDetails)
    .subscribe({
      next: (response) => {
        this.router.navigate(['borrows']);
      }
    });
  }

  deleteBorrow(BorrowId: string) {
    this.borrowService.deleteBorrow(BorrowId)
    .subscribe({
      next: (response) => {
        this.router.navigate(['borrows']);
      }
    });
  }

}
