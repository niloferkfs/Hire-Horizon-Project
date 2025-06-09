import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SkillViewComponent } from '../Components/skill-view/skill-view.component';
import { SkillHomeComponent } from '../Components/skill-home/skill-home.component';
import { SkillAddComponent } from '../Components/skill-add/skill-add.component';

const routes: Routes = [{
  path: '', component: SkillHomeComponent,
  children: [
    {
      path: 'addSkill', component: SkillAddComponent
    },
    {
      path: 'viewSkill', component: SkillViewComponent
    }
  ]
}];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class SkillsRoutingModule { }
