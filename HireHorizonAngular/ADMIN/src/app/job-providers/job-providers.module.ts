import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { JobProvidersRoutingModule } from './routes/job-providers-routing.module';
import { JobProvidersHomeComponent } from './Components/job-providers-home/job-providers-home.component';
import { ProvidersListComponent } from './Components/providers-list/providers-list.component';
import { FormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    JobProvidersHomeComponent,
    ProvidersListComponent
  ],
  imports: [
    CommonModule,
    JobProvidersRoutingModule,
    FormsModule
  ]
})
export class JobProvidersModule { }
