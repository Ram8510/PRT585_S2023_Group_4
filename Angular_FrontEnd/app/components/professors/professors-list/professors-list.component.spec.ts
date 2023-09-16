import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProfessorsListComponent } from './professors-list.component';

describe('ProfessorsListComponent', () => {
  let component: ProfessorsListComponent;
  let fixture: ComponentFixture<ProfessorsListComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ProfessorsListComponent]
    });
    fixture = TestBed.createComponent(ProfessorsListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
