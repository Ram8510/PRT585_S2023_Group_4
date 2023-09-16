import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Instrument } from 'src/app/models/instrument.model';
import { InstrumentsService } from 'src/app/services/instruments.service';

@Component({
  selector: 'app-add-instrument',
  templateUrl: './add-instrument.component.html',
  styleUrls: ['./add-instrument.component.css']
})
export class AddInstrumentComponent implements OnInit {

  addInstrumentRequest: Instrument = {
    InstrumentId: '',
    InstrumentName: '',
    InstrumentStatus: ''
  };

  constructor(private instrumentService: InstrumentsService, private router: Router){}
  
  ngOnInit(): void {
      
  }

  addInstrument(){
    this.instrumentService.addInstrument(this.addInstrumentRequest)
    .subscribe({
      next: (instrument) => {
        this.router.navigate(['instruments']);
      }
    });
  }


  

}
