import { RouterModule, Routes } from '@angular/router';

import { AddTicketComponent } from './components/ticket/add-ticket/add-ticket.component';
import { AdmindashboardComponent } from './components/admin/admindashboard/admindashboard.component';
import { AuthGuard } from './shared/service/auth.guard';
import { DashboardComponent } from './components/user/dashboard/dashboard.component';
import { HomeComponent } from './components/home/home.component';
import { LandingPageComponent } from './components/user/landing-page/landing-page.component';
import { LoginComponent } from './components/shared/login/login.component';
import { NgModule } from '@angular/core';
import { PageNotFoundComponent } from './components/shared/page-not-found/page-not-found.component';
import { UpdateTicketComponent } from './components/ticket/update-ticket/update-ticket.component';
import { ViewTicketComponent } from './components/ticket/view-ticket/view-ticket.component';

const routes: Routes = [
  {path:'',component:LoginComponent},
  {path:'dashboard',component:AdmindashboardComponent,children:[
    {path:'home',component:HomeComponent}
  ]},
  {path:'landingpage',component:LandingPageComponent,canActivate:[AuthGuard]},
  {path:"add",component:AddTicketComponent},
  {path:"userdashboard",component:DashboardComponent},
  {path:'viewticket/:id',component:ViewTicketComponent},
  {path:'viewticket/:id/edit/:id',component:UpdateTicketComponent},
  {path:'**',component:PageNotFoundComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
