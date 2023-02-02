import { environment } from './../environments/environment';
import { HttpClient, HttpEvent, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Itodo } from "../app/interfaces/Itodo";
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ToDoService {

  constructor(private http: HttpClient) { }

  getAllToDo(): Observable<Itodo[]> {
    return this.http.get<Itodo[]>(`${environment.ApiUrl}/ToDo`);
  }

  addTodo(todo: any): Observable<any> {
    const headers = { 'content-type': 'application/json' }
    const body = JSON.stringify(todo);
    return this.http.post(`${environment.ApiUrl}/ToDo`, body, { 'headers': headers, observe: 'response' })
  }

}
