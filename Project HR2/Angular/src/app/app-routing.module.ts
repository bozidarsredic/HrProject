
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { UserComponent } from './user/user.component';
import { RegistrationComponent } from './user/registration/registration.component';

import { HomeComponent } from './home/home.component';
import { SkillComponent } from './skill/skill.component';
import { UserDetailComponent } from './user-detail/user-detail.component';




const routes: Routes = [
  {path:'',redirectTo:'/user/registration',pathMatch:'full'},


  {
    path: 'user', component: UserComponent,
    children: [
      { path: 'registration', component: RegistrationComponent },


    ]
  },
  {path:'home',component:HomeComponent},
  {path:'skill',component:SkillComponent},
  {path:'userDetail',component:UserDetailComponent},


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
