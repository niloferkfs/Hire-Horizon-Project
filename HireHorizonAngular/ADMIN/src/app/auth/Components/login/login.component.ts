import { Component } from '@angular/core';
import { AuthServiceService } from '../../services/auth-service.service';
import { Router } from '@angular/router';

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

  constructor(private authService: AuthServiceService, private router: Router) {
    this.email='';
    this.password='';
    this.loginError = false;
    this.isLoggedIn = false;
  }

  login(){
    const credentials = {
      email: this.email,
      password: this.password
    };

    this.authService.login(credentials).subscribe(
      (response:any) => {
        this.isLoggedIn = true;
        console.log(response,response['token']);

        localStorage.setItem('accessToken',response['token']);
        sessionStorage.setItem('email',response.email);
        // Redirect to home or another page upon successful login
        this.router.navigate(['/admin-home']);
      },
      (error) => {
        console.error('Login failed:', error);
        this.loginError = true;
        
      }
    );
  }


  }

