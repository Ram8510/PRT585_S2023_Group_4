import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditBorrowComponent } from './edit-borrow.component';

describe('EditBorrowComponent', () => {
  let component: EditBorrowComponent;
  let fixture: ComponentFixture<EditBorrowComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [EditBorrowComponent]
    });
    fixture = TestBed.createComponent(EditBorrowComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
