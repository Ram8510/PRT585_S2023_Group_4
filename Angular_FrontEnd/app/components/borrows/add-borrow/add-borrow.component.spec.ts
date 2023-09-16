import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddBorrowComponent } from './add-borrow.component';

describe('AddBorrowComponent', () => {
  let component: AddBorrowComponent;
  let fixture: ComponentFixture<AddBorrowComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AddBorrowComponent]
    });
    fixture = TestBed.createComponent(AddBorrowComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
