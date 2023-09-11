import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BookListComponent } from './components/books/book-list/book-list.component';
import { AddBookComponent } from './components/books/add-book/add-book.component';
import { EditBookComponent } from './components/books/edit-book/edit-book.component';
const routes: Routes = [
  {
    path: '',
    component: BookListComponent
  },
  {
    path: 'books',
    component: BookListComponent
  },
  {
    path: 'books/add',
    component: AddBookComponent
  },
  {
    path: 'books/edit/:id',
    component: EditBookComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
