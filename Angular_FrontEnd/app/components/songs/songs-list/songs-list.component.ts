import { Component, OnInit } from '@angular/core';
import { Song } from 'src/app/models/song.model';
import { SongsService } from 'src/app/services/songs.service';


@Component({
  selector: 'app-songs-list',
  templateUrl: './songs-list.component.html',
  styleUrls: ['./songs-list.component.css']
})
export class SongsListComponent implements OnInit {

  songs: Song[] = [];

  constructor(private songsService: SongsService) {}



  ngOnInit(): void {
    this.songsService.getAllSongs()
    .subscribe({
      next: (songs) => {
        this.songs = songs;
      },
      error: (response) => {
        console.log(response);
      }
    })
  }



}
