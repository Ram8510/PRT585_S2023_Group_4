import { Component } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { MovieCreateEditComponent } from './movie-create-edit/movie-create-edit.component'

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'Movie-app';

  constructor(private _dialog: MatDialog){}

  openMovieCreateEditForm(){
    this._dialog.open(MovieCreateEditComponent);
  }
}
