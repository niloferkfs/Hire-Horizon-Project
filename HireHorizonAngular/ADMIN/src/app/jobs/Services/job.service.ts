import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environments';
import { Jobs } from '../Models/job.model';

@Injectable({
  providedIn: 'root'
})
export class JobService {

  private jobsUrl = environment.baseurl+`/Alljobs`; 
  private jobFilterUrl=environment.baseurl +`/admin/jobsbyTitle`;
    constructor(private http: HttpClient) { }
  
    getJobs(): Observable<Jobs[]> {
      return this.http.get<Jobs[]>(this.jobsUrl);
    }
  
    filterJobs(searchTerm: string): Observable<Jobs[]> {
      return this.http.get<Jobs[]>(this.jobFilterUrl+`?Title=${searchTerm}`);
    }
    
}
