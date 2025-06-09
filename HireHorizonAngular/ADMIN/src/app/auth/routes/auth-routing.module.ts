import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from '../Components/login/login.component';
import { AuthHomeComponent } from '../Components/auth-home/auth-home.component';

const routes: Routes = [{
  path:'',component:AuthHomeComponent,
  children:[
    {path:'',component:LoginComponent},
    {path:'Login',component:LoginComponent}
  ]
}];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AuthRoutingModule { }
