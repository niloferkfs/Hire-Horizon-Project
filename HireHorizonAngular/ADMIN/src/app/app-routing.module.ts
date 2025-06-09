import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [{
  path:'',loadChildren:()=>import('./auth/auth.module').then(m=>m.AuthModule)
},
{
  path:'',loadChildren:()=>import('./admin-home/admin-home.module').then(m=>m.AdminHomeModule)
},

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
