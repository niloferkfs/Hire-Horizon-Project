import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { SkillsRoutingModule } from './routes/skills-routing.module';
import { SkillAddComponent } from './Components/skill-add/skill-add.component';
import { SkillHomeComponent } from './Components/skill-home/skill-home.component';
import { SkillViewComponent } from './Components/skill-view/skill-view.component';
import { MatInputModule } from '@angular/material/input';
import { MatIconModule } from '@angular/material/icon';
import { FormsModule } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    SkillAddComponent,
    SkillHomeComponent,
    SkillViewComponent
  ],
  imports: [
    CommonModule,
    SkillsRoutingModule,
    MatInputModule,
    MatIconModule,
    FormsModule,
    ReactiveFormsModule
  
  ]
})
export class SkillsModule { }
