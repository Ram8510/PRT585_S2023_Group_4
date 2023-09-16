import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Song } from 'src/app/models/song.model';
import { SongsService } from 'src/app/services/songs.service';

@Component({
  selector: 'app-edit-song',
  templateUrl: './edit-song.component.html',
  styleUrls: ['./edit-song.component.css']
})
export class EditSongComponent implements OnInit {

  songDetails: Song = {
    SongId: '',
    SongName: '',
    SongAuthor: ''

  };

  constructor(private route: ActivatedRoute, private songService: SongsService, private router: Router) {}

  ngOnInit(): void {
    this.route.paramMap.subscribe({
      next: (params) => {
        const SongId = params.get('SongId');

        if (SongId) {
          this.songService.getSong(SongId)
          .subscribe({
            next: (response) => {
              this.songDetails = response;
            }
          })
        }
      }
    })
      
  }

  updateSong() {
    this.songService.updateSong(this.songDetails.SongId, this.songDetails)
    .subscribe({
      next: (response) => {
        this.router.navigate(['songs']);
      }
    });
  }

  deleteSong(SongId: string) {
    this.songService.deleteSong(SongId)
    .subscribe({
      next: (response) => {
        this.router.navigate(['songs']);
      }
    });
  }

}
