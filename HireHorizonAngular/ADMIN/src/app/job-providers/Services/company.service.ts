import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Companies } from '../Models/Companies';
import { environment } from 'src/environments/environments';

@Injectable({
  providedIn: 'root'
})
export class CompanyService {

  private removeCompanyUrl=environment.baseurl+`/admin/RemoveCompanies/`;
  private companiesUrl = environment.baseurl+`/admin/GetCompanies`; 
  private searchUrl = environment.baseurl+`/admin/SearchCompanies`; 
  

  constructor(private http:HttpClient) { }

  getCompanies():Observable<Companies[]>{

    return this.http.get<Companies[]>(this.companiesUrl)
  }

  removeCompany(id: string):Observable<any>{
    
    const Url = `${this.companiesUrl}${id}`;
    return this.http.delete(Url);
  }

  searchCompany(seachTerm:string){
    return this.http.get<Companies[]>(this.searchUrl + `?name=${seachTerm}`);
  }

}
