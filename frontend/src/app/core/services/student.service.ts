import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Student } from '../models/Student';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class StudentService {
  constructor(
    private http: HttpClient
  ) { }

  getStudent(id: string): Observable<Student> {
    return this.http.get<Student>(`${environment.backend_api}student/${id}`);
  }

  getAllStudents(): Observable<Student[]> {
    return this.http.get<Student[]>(`${environment.backend_api}student`);
  }

  createStudent(student: Student): Observable<Student> {
    return this.http.post<Student>(`${environment.backend_api}student`, student);
  }

  deleteStudent(id: string): Observable<Student> {
    return this.http.delete<Student>(`${environment.backend_api}student/${id}`);
  }

  getAllCountries() {
    return this.http.get(`https://restcountries.com/v3.1/all?fields=name`);
  }
}
