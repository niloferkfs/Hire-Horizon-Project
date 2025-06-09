import { Component } from '@angular/core';
import { AuthServiceService } from 'src/app/auth/services/auth-service.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.css']
})
export class SidebarComponent {

  constructor(private authservice : AuthServiceService,private router: Router) { }

  

  navigateToDashboard() {
    this.router.navigate(['/admin-home/dashboard']);
  }

  navigateToNewRegistrations() {
    this.router.navigate(['/admin-home/new-registration/registrations']);
  }

  navigateToMessages() {
    this.router.navigate(['/admin-home/messages']);
  }

  navigateToSettings() {
    this.router.navigate(['/admin-home/setting/update']);
  }

  navigateToJobProviders() {
    this.router.navigate(['/admin-home/job-provider/list']);
  }

  navigateToJobs() {
    this.router.navigate(['/admin-home/jobs/list']);
  }

  navigateToJobSeekers() {
    this.router.navigate(['/admin-home/job-seeker/list']);
  }
  navigateToSkills() {
    this.router.navigate(['/admin-home/skill/addSkill']);
  }
  logout(): void {
    this.authservice.logout();
    this.router.navigate(['/login']);

  }
}



