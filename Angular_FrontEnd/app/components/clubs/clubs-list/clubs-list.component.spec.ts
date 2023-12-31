import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ClubsListComponent } from './clubs-list.component';

describe('ClubsListComponent', () => {
  let component: ClubsListComponent;
  let fixture: ComponentFixture<ClubsListComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ClubsListComponent]
    });
    fixture = TestBed.createComponent(ClubsListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
