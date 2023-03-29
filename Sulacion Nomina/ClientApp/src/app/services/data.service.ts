import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Teacher } from '../models/teacher';

@Injectable({
  providedIn: 'root'
})
export class DataService {
  private readonly API = "/api/data/simulate";
  constructor(private readonly htpp: HttpClient) { }

  sendData(teachers: Teacher[]){
    return this.htpp.post(this.API, teachers);
  }
}
