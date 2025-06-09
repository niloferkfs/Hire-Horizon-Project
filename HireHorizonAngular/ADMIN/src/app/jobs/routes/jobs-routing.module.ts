import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { JobHomeComponent } from '../Components/job-home/job-home.component';
import { JobListComponent } from '../Components/job-list/job-list.component';

const routes: Routes = [{
  path:'',component:JobHomeComponent,
  children:[
    {
      path:'list',component:JobListComponent
    }
  ]
}];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class JobsRoutingModule { }
