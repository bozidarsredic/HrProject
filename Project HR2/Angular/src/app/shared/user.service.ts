import { Injectable } from '@angular/core';
import { FormBuilder, Validators, FormGroup } from '@angular/forms';
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';

import { Registration } from './models/registration.model';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor( private http: HttpClient) { }


  register(registration:Registration) :Observable<String> {

    return this.http.post<String>(environment.serverURL + '/api/users/registration', registration);

  }

  getUsers() : Observable<Registration[]> {
    return this.http.get<Registration[]>(environment.serverURL + '/api/users/all');
  }

  getUserById(id:number) : Observable<Registration> {
    return this.http.get<Registration>(environment.serverURL + `/api/users/${id}`);
  }

 deleteCandidat(id:number) :Observable<String> {

    return this.http.post<String>(environment.serverURL + '/api/users/deletecandidat', id);

  }

}
