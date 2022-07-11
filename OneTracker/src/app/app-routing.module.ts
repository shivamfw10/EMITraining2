import { RouterModule, Routes } from '@angular/router';

import { AdmindashboardComponent } from './components/admin/admindashboard/admindashboard.component';
import { AuthGuard } from './shared/service/auth.guard';
import { LandingPageComponent } from './components/user/landing-page/landing-page.component';
import { LoginComponent } from './components/shared/login/login.component';
import { NgModule } from '@angular/core';

const routes: Routes = [
  {path:'',component:LoginComponent},
  {path:'dashboard',component:AdmindashboardComponent},
  {path:'landingpage',component:LandingPageComponent,canActivate:[AuthGuard]}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
