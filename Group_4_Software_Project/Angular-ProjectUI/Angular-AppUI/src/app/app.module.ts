import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BookListComponent } from './components/books/book-list/book-list.component';
import { HttpClientModule } from '@angular/common/http';
import { AddBookComponent } from './components/books/add-book/add-book.component';
import { EditBookComponent } from './components/books/edit-book/edit-book.component';

@NgModule({
  declarations: [
    AppComponent,
    BookListComponent,
    AddBookComponent,
    EditBookComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
