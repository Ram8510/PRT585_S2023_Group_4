import { Component } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-emp-add-edit',
  templateUrl: './emp-add-edit.component.html',
  styleUrls: ['./emp-add-edit.component.scss']
})
export class EmpAddEditComponent {
  empForm: FormGroup;
  genre: string[] = [
    'Romantic',
    'Fictional',
    'Sci-Fi',
    'Adventure'
  ];
  constructor(private _fb: FormBuilder) {
    this.empForm = this._fb.group({
      bookName: '',
      authorName: '',
      versiom: '',
      email: '',
      dop: '',
      genre: '',
    })
  }

onFormSubmit() {
  if (this.empForm.valid) {
    console.log(this.empForm.value);
  }
  }
}