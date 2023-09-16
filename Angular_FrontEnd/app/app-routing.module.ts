import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SongsListComponent } from './components/songs/songs-list/songs-list.component';
import { AddSongComponent } from './components/songs/add-song/add-song.component';
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

const routes: Routes = [
  {
    path: '',
    component:SongsListComponent
  },
  {
    path: 'songs',
    component:SongsListComponent
  },
  {
    path: 'songs/add',
    component: AddSongComponent
  },
  {
    path: 'songs/edit/:SongId',
    component: EditSongComponent
  },



  {
    path: '',
    component:InstrumentsListComponent
  },
  {
    path: 'instruments',
    component:InstrumentsListComponent
  },
  {
    path: 'instruments/add',
    component: AddInstrumentComponent
  },
  {
    path: 'instruments/edit/:InstrumentId',
    component: EditInstrumentComponent
  },


  {
    path: '',
    component:ProfessorsListComponent
  },
  {
    path: 'professors',
    component:ProfessorsListComponent
  },
  {
    path: 'professors/add',
    component: AddProfessorComponent
  },
  {
    path: 'professors/edit/:ProfessorId',
    component: EditProfessorComponent
  },


  {
    path: '',
    component:BuildingsListComponent
  },
  {
    path: 'buildings',
    component:BuildingsListComponent
  },
  {
    path: 'buildings/add',
    component: AddBuildingComponent
  },
  {
    path: 'buildings/edit/:BuildingId',
    component: EditBuildingComponent
  },




  {
    path: '',
    component:BooksListComponent
  },
  {
    path: 'books',
    component:BooksListComponent
  },
  {
    path: 'books/add',
    component: AddBookComponent
  },
  {
    path: 'books/edit/:BookId',
    component: EditBookComponent
  },



  {
    path: '',
    component:BorrowsListComponent
  },
  {
    path: 'borrows',
    component:BorrowsListComponent
  },
  {
    path: 'borrows/add',
    component: AddBorrowComponent
  },
  {
    path: 'borrows/edit/:BorrowId',
    component: EditBorrowComponent
  },



  {
    path: '',
    component:ClubsListComponent
  },
  {
    path: 'clubs',
    component:ClubsListComponent
  },
  {
    path: 'clubs/add',
    component: AddClubComponent
  },
  {
    path: 'clubs/edit/:ClubId',
    component: EditClubComponent
  },








];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
