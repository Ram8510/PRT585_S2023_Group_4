import { Component } from '@angular/core';
import { EmpAddEditComponent } from './emp-add-edit/emp-add-edit.component';
import { MatDialog } from '@angular/material/dialog';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'movie-app';

  constructor(private _diaglog: MatDialog) {}
  openAddEditEmpForm() {
    this._diaglog.open(EmpAddEditComponent);
  }
}
