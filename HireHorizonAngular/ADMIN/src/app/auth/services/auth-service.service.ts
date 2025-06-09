import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environments';

@Injectable({
  providedIn: 'root'
})
export class AuthServiceService {

  private loginUrl=environment.baseurl+`/Admin/Login`;
  private isloggedin: boolean= false;

  constructor(private http:HttpClient) { }

  login(credentials: { email: string, password: string }): Observable<any> {

    return this.http.post(this.loginUrl, credentials);
  }
  logout(): void {
    this.isloggedin = false;
  }

  isAuthenticated(): boolean {
    return !!localStorage.getItem('accessToken'); //The !! is a common JavaScript/TypeScript idiom used to convert any value to a boolean.


  }
  getToken(): any {
    return localStorage.getItem('accessToken') // Return an empty string if the token is null or undefined
  }
}
