import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environments';

@Injectable({
  providedIn: 'root'
})
export class DashboardService {

  private jobsUrl = environment.baseurl+'/admin/GetJobCount';
  private jobSeekersUrl = environment.baseurl+'/admin/GetJobSeekers';
  private companiesUrl = environment.baseurl+'/admin/GetJobProviderCount';
  private jobProvidersUrl = environment.baseurl+'/admin/GetJobProviderCount';

  constructor(private http:HttpClient) { }

  getTotaljobsPosted() {
    return this.http.get<any>(this.jobsUrl);
    }
    getTotaljobSeekers() {
      return this.http.get<any>(this.jobSeekersUrl);
      }
      getTotalcompanies(){
        return this.http.get<any>(this.companiesUrl);
      }
      getTotalJobProvider(){
        return this.http.get<any>(this.jobProvidersUrl);
        }
      
}
