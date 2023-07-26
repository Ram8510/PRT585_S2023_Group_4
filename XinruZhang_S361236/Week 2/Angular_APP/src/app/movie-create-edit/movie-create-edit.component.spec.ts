import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MovieCreateEditComponent } from './movie-create-edit.component';

describe('MovieCreateEditComponent', () => {
  let component: MovieCreateEditComponent;
  let fixture: ComponentFixture<MovieCreateEditComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [MovieCreateEditComponent]
    });
    fixture = TestBed.createComponent(MovieCreateEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
