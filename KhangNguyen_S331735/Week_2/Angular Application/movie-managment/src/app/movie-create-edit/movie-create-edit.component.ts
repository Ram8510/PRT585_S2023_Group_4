import { Component } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { MovieService } from '../services/movie.service';
import { DialogRef } from '@angular/cdk/dialog';

@Component({
  selector: 'app-movie-create-edit',
  templateUrl: './movie-create-edit.component.html',
  styleUrls: ['./movie-create-edit.component.scss']
})
export class MovieCreateEditComponent {
  movieForm: FormGroup;



  language: string[] = [
    'English',
    'Japanese',
    'Chinese',
    'France',
  ];
  

  constructor(private _fb: FormBuilder, private _movieService: MovieService, private _dialogRef: DialogRef<MovieCreateEditComponent>) {
    /* An Angular constructor is a function that is used to initialize an Angular application. The constructor is run when the application is first created, and it is responsible for setting up the Angular environment.
    
    The constructor can be used to inject dependencies, set the default values for properties, and run any other initialization code that is needed.
    
    */
    this.movieForm = this._fb.group({
      movieID: '',
      movieName: '',
      movieCode: '',
      releaseDate: '',
      directorName: '',
      movieLanguage: '',
      

    });
  }

  onFormSubmit() {
    if (this.movieForm.valid) {
      this._movieService.addMovie(this.movieForm.value).subscribe({
        next: (val: any) => {
          alert('Movie has been added successfully');
          this._dialogRef.close();
        },
        error: (err: any) => {
          console.error(err);
        }
        
        
      })
    }
  }

}
