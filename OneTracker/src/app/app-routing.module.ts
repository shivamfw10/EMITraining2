import { RouterModule, Routes } from '@angular/router';

import { AddTicketComponent } from './components/ticket-list/add-ticket/add-ticket.component';
import { AdduserComponent } from './components/user-list/adduser/adduser.component';
import { AdminDashboardComponent } from './components/admin-dashboard/admin-dashboard.component';
import { AdminHomeComponent } from './components/admin-home/admin-home.component';
import { AuthGuard } from './core/services/auth.guard';
import { LoginComponent } from './components/login/login.component';
import { NgModule } from '@angular/core';
import { PageNotFoundComponent } from './components/page-not-found/page-not-found.component';
import { TicketListComponent } from './components/ticket-list/ticket-list.component';
import { TicketsComponent } from './components/tickets/tickets.component';
import { UpdateTicketComponent } from './components/ticket-list/update-ticket/update-ticket.component';
import { UserDashboardComponent } from './components/user-dashboard/user-dashboard.component';
import { UserHomeComponent } from './components/user-home/user-home.component';
import { UserListComponent } from './components/user-list/user-list.component';
import { ViewTicketComponent } from './components/ticket-list/view-ticket/view-ticket.component';

const routes: Routes = [
  {path:'',component:LoginComponent,pathMatch:"full"},
  {path:'dashboard',component:AdminDashboardComponent,canActivate:[AuthGuard],children:[
    {path:'home',component:AdminHomeComponent},
    {path:'ticket',component:TicketListComponent},
    {path:'userlist',component:UserListComponent},
    {path:'adduser',component:AdduserComponent}
  ]},
  {path:'landingpage',component:UserHomeComponent,canActivate:[AuthGuard],children:[
    {path:"tickets",component:TicketsComponent,children:[
      {path:'viewticket/:id',component:ViewTicketComponent}
    ]},
    {path:"addticket",component:AddTicketComponent},
    {path:"userdashboard",component:UserDashboardComponent},
  ]},
  {path:'viewticket/:id/edit/:id',component:UpdateTicketComponent},
  {path:'**',component:PageNotFoundComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
