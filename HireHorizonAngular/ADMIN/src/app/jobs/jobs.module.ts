import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { JobsRoutingModule } from './routes/jobs-routing.module';
import { JobHomeComponent } from './Components/job-home/job-home.component';
import { JobListComponent } from './Components/job-list/job-list.component';
import { FormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    JobHomeComponent,
    JobListComponent
  ],
  imports: [
    CommonModule,
    JobsRoutingModule,
    FormsModule
  ]
})
export class JobsModule { }
