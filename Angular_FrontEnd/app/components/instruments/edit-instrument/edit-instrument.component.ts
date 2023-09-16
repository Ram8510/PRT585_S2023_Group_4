import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Instrument } from 'src/app/models/instrument.model';
import { InstrumentsService } from 'src/app/services/instruments.service';

@Component({
  selector: 'app-edit-instrument',
  templateUrl: './edit-instrument.component.html',
  styleUrls: ['./edit-instrument.component.css']
})
export class EditInstrumentComponent implements OnInit {
  
  instrumentDetails: Instrument = {
    InstrumentId: '',
    InstrumentName: '',
    InstrumentStatus: ''

  };

  constructor(private route: ActivatedRoute, private instrumentService: InstrumentsService, private router: Router) {}

  ngOnInit(): void {
    this.route.paramMap.subscribe({
      next: (params) => {
        const InstrumentId = params.get('InstrumentId');

        if (InstrumentId) {
          this.instrumentService.getInstrument(InstrumentId)
          .subscribe({
            next: (response) => {
              this.instrumentDetails = response;
            }
          })
        }
      }
    })
      
  }

  updateInstrument() {
    this.instrumentService.updateInstrument(this.instrumentDetails.InstrumentId, this.instrumentDetails)
    .subscribe({
      next: (response) => {
        this.router.navigate(['instruments']);
      }
    });
  }

  deleteInstrument(InstrumentId: string) {
    this.instrumentService.deleteInstrument(InstrumentId)
    .subscribe({
      next: (response) => {
        this.router.navigate(['instruments']);
      }
    });
  }

}
