import { Component, OnInit } from '@angular/core';
import { Instrument } from 'src/app/models/instrument.model';
import { InstrumentsService } from 'src/app/services/instruments.service';

@Component({
  selector: 'app-instruments-list',
  templateUrl: './instruments-list.component.html',
  styleUrls: ['./instruments-list.component.css']
})
export class InstrumentsListComponent implements OnInit {

  instruments: Instrument[] = [];

  constructor(private instrumentsService: InstrumentsService){}

  ngOnInit(): void {
    this.instrumentsService.getAllInstruments()
    .subscribe({
      next: (instruments) => {
        this.instruments = instruments;
      },
      error: (response) => {
        console.log(response);
      }
    })
  }

  

}
