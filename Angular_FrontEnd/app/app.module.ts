import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SongsListComponent } from './components/songs/songs-list/songs-list.component';
import { HttpClientModule } from '@angular/common/http';
import { AddSongComponent } from './components/songs/add-song/add-song.component';
import { FormsModule } from '@angular/forms';
import { EditSongComponent } from './components/songs/edit-song/edit-song.component';
import { InstrumentsListComponent } from './components/instruments/instruments-list/instruments-list.component';
import { AddInstrumentComponent } from './components/instruments/add-instrument/add-instrument.component';
import { EditInstrumentComponent } from './components/instruments/edit-instrument/edit-instrument.component';
import { ProfessorsListComponent } from './components/professors/professors-list/professors-list.component';
import { AddProfessorComponent } from './components/professors/add-professor/add-professor.component';
import { EditProfessorComponent } from './components/professors/edit-professor/edit-professor.component';
import { BuildingsListComponent } from './components/buildings/buildings-list/buildings-list.component';
import { AddBuildingComponent } from './components/buildings/add-building/add-building.component';
import { EditBuildingComponent } from './components/buildings/edit-building/edit-building.component';
import { BooksListComponent } from './components/books/books-list/books-list.component';
import { AddBookComponent } from './components/books/add-book/add-book.component';
import { EditBookComponent } from './components/books/edit-book/edit-book.component';
import { BorrowsListComponent } from './components/borrows/borrows-list/borrows-list.component';
import { AddBorrowComponent } from './components/borrows/add-borrow/add-borrow.component';
import { EditBorrowComponent } from './components/borrows/edit-borrow/edit-borrow.component';
import { ClubsListComponent } from './components/clubs/clubs-list/clubs-list.component';
import { AddClubComponent } from './components/clubs/add-club/add-club.component';
import { EditClubComponent } from './components/clubs/edit-club/edit-club.component';

@NgModule({
  declarations: [
    AppComponent,
    SongsListComponent,
    AddSongComponent,
    EditSongComponent,
    InstrumentsListComponent,
    AddInstrumentComponent,
    EditInstrumentComponent,
    ProfessorsListComponent,
    AddProfessorComponent,
    EditProfessorComponent,
    BuildingsListComponent,
    AddBuildingComponent,
    EditBuildingComponent,
    BooksListComponent,
    AddBookComponent,
    EditBookComponent,
    BorrowsListComponent,
    AddBorrowComponent,
    EditBorrowComponent,
    ClubsListComponent,
    AddClubComponent,
    EditClubComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
