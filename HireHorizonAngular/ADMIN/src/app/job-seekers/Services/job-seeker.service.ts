import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environments';
import { data } from '../Models/JobSeekerListModel'

@Injectable({
  providedIn: 'root'
})
export class JobSeekerService {

  private DataUrl = environment.baseurl+'/admin/GetJobSeekers';

  constructor(private http: HttpClient) { }

  getData(): Observable<data[]> {
    return this.http.get<data[]>(this.DataUrl);
  }
}
