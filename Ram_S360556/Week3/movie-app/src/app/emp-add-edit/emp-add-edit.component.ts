import { Component } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-emp-add-edit',
  templateUrl: './emp-add-edit.component.html',
  styleUrls: ['./emp-add-edit.component.scss']
})
export class EmpAddEditComponent {
  empForm: FormGroup;
  position: string[] = [
    'Forward',
    'Midfielder',
    'Defender',
    'GoalKeeper'
  ];
  constructor(private _fb: FormBuilder) {
    this.empForm = this._fb.group({
      firstName: '',
      lastName: '',
      country: '',
      email: '',
      dob: '',
      position: '',
    })
  }

onFormSubmit() {
  if (this.empForm.valid) {
    console.log(this.empForm.value);
  }
  }
}