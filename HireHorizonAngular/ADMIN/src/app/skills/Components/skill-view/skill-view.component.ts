import { Component } from '@angular/core';
import { SkillServiceService } from '../../Services/skill-service.service';
import { Router } from '@angular/router';
import { Skill } from '../../Models/skill';

@Component({
  selector: 'app-skill-view',
  templateUrl: './skill-view.component.html',
  styleUrls: ['./skill-view.component.css']
})
export class SkillViewComponent {

  skills: any;
  constructor(private skillService: SkillServiceService, private router: Router) { }

  ngOnInit(): void {
    this.getSkill();
  }
  getSkill() {
    this.skillService.getSkills().subscribe((skill) => {
      this.skills = skill;
      console.log(this.skills);

    })
  }
  navigateToAddSkills() {
    // Navigate to the 'viewSkill' route
    this.router.navigate(['/admin-home/skill/addSkill']);
  }
  deleteSkill(skillId: string) {
    if (confirm('Are you sure you want to delete this skill?')) {
      this.skillService.deleteSkill(skillId).subscribe(
        () => {
          console.log('Skill deleted successfully');
          window.location.reload;
        },
        (error) => {
          console.error('Error deleting skill:', error);
          // Handle error, show a message, etc.
        }
      );
    }
  }

  }



