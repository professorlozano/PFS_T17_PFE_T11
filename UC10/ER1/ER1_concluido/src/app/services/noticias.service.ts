import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Noticias } from '../models/noticias';


@Injectable({
  providedIn: 'root'
})
export class NoticiasService {

  url = "http://localhost:3000/noticias"

  constructor(private httpClient: HttpClient) { }
  
  getNoticias():Observable<Noticias[]>{
    return this.httpClient.get<Noticias[]>(this.url)
  }
}
