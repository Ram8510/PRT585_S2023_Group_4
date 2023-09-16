import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Song } from 'src/app/models/song.model';
import { SongsService } from 'src/app/services/songs.service';

@Component({
  selector: 'app-add-song',
  templateUrl: './add-song.component.html',
  styleUrls: ['./add-song.component.css']
})
export class AddSongComponent implements OnInit {

  addSongRequest: Song = {
    SongId: '',
    SongName: '',
    SongAuthor: ''
  };

  constructor(private songService: SongsService, private router: Router){}
  
  ngOnInit(): void {
      
  }

  addSong(){
    this.songService.addSong(this.addSongRequest)
    .subscribe({
      next: (song) => {
        this.router.navigate(['songs']);
      }
    });
  }

}
