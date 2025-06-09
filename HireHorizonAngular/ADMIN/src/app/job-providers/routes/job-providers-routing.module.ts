import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { JobProvidersHomeComponent } from '../Components/job-providers-home/job-providers-home.component';
import { ProvidersListComponent } from '../Components/providers-list/providers-list.component';

const routes: Routes = [{
  path:'',component:JobProvidersHomeComponent,
  children:[
    {
      path:'list',component:ProvidersListComponent
    }
  ]
}];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class JobProvidersRoutingModule { }
