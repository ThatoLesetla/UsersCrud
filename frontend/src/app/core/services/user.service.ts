import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../../environments/environment';
import { User } from '../models/User';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(
    private http: HttpClient
  ) { }

  getAllUsers() {
    return this.http.get(`${environment.backend_api}/user`);
  }

  createUser(user: User) {
    return this.http.post(`${environment.backend_api}user`, user);
  }

}
