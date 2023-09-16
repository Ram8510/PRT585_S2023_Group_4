import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Song } from '../models/song.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SongsService {

  baseApiUrl: string = environment.baseApiUrl;

  constructor(private http: HttpClient) { }


  getAllSongs(): Observable<Song[]> {
    return this.http.get<Song[]>('https://localhost:7246/api/Song');
    
  }

  addSong(addSongRequest: Song): Observable<Song> {
    addSongRequest.SongId = '0';
    return this.http.post<Song>(this.baseApiUrl + '/api/Song', addSongRequest);
  }

  getSong(SongId: string): Observable<Song> {
    return this.http.get<Song>(this.baseApiUrl + '/api/Song/' + SongId)
  }

  updateSong(SongId: string, updateSongRequest: Song): Observable<Song> {
    return this.http.put<Song>(this.baseApiUrl + '/api/Song/' + SongId, updateSongRequest);
  }

  deleteSong(SongId: string): Observable<Song> {
    return this.http.delete<Song>(this.baseApiUrl + '/api/Song/' + SongId);
  }

}
