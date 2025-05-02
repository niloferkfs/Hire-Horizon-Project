import { Component } from '@angular/core';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {

  email!: string;
  password: string;
  loginError: boolean;
  isLoggedIn: boolean;

  constructor() {
    this.email='';
    this.password='';
    this.loginError = false;
    this.isLoggedIn = false;
  }

  login(){
    
  }
}
