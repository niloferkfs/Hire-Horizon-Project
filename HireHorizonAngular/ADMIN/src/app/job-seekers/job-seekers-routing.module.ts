import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { JobSeekersHomeComponent } from './Components/job-seekers-home/job-seekers-home.component';
import { JobSeekerComponent } from './Components/job-seeker/job-seeker.component';

const routes: Routes = [{
  path:'',component:JobSeekersHomeComponent,
  children:[{path:'list',component:JobSeekerComponent}]
}
  
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class JobSeekersRoutingModule { }
