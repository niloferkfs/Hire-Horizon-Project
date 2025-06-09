import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { JobSeekersRoutingModule } from './job-seekers-routing.module';
import { JobSeekersHomeComponent } from './Components/job-seekers-home/job-seekers-home.component';
import { JobSeekerComponent } from './Components/job-seeker/job-seeker.component';


@NgModule({
  declarations: [
    JobSeekersHomeComponent,
    JobSeekerComponent
  ],
  imports: [
    CommonModule,
    JobSeekersRoutingModule
  ]
})
export class JobSeekersModule { }
