import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditInstrumentComponent } from './edit-instrument.component';

describe('EditInstrumentComponent', () => {
  let component: EditInstrumentComponent;
  let fixture: ComponentFixture<EditInstrumentComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [EditInstrumentComponent]
    });
    fixture = TestBed.createComponent(EditInstrumentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
