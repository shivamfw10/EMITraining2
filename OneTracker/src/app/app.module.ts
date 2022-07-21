import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { AddTicketComponent } from './components/ticket-list/add-ticket/add-ticket.component';
import { AdduserComponent } from './components/user-list/adduser/adduser.component';
import { AdminDashboardComponent } from './components/admin-dashboard/admin-dashboard.component';
import { AdminHomeComponent } from './components/admin-home/admin-home.component';
import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { LoginComponent } from './components/login/login.component';
import { MatMaduleModule } from './core/mat-madule/mat-madule.module';
import { Ng2SearchPipeModule } from 'ng2-search-filter';
import { NgModule } from '@angular/core';
import { PageNotFoundComponent } from './components/page-not-found/page-not-found.component';
import { SidebarComponent } from './components/sidebar/sidebar.component';
import { TicketListComponent } from './components/ticket-list/ticket-list.component';
import { TicketsComponent } from './components/tickets/tickets.component';
import { ToastrModule } from 'ngx-toastr';
import { UpdateTicketComponent } from './components/ticket-list/update-ticket/update-ticket.component';
import { UpdateuserComponent } from './components/user-list/updateuser/updateuser.component';
import { UserDashboardComponent } from './components/user-dashboard/user-dashboard.component';
import { UserHomeComponent } from './components/user-home/user-home.component';
import { UserListComponent } from './components/user-list/user-list.component';
import { UserNavbarComponent } from './components/user-navbar/user-navbar.component';
import { ViewTicketComponent } from './components/ticket-list/view-ticket/view-ticket.component';
import { ViewuserComponent } from './components/user-list/viewuser/viewuser.component';

@NgModule({
  declarations: [
    AppComponent,
    AdminDashboardComponent,
    UserHomeComponent,
    SidebarComponent,
    UserListComponent,
    AdduserComponent,
    UpdateuserComponent,
    ViewuserComponent,
    PageNotFoundComponent,
    UserNavbarComponent,
    TicketListComponent,
    AddTicketComponent,
    UpdateTicketComponent,
    ViewTicketComponent,
    LoginComponent,
    AdminHomeComponent,
    UserDashboardComponent,
    TicketsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    ReactiveFormsModule,
    FormsModule,
    HttpClientModule,
    MatMaduleModule,
    Ng2SearchPipeModule,
    ToastrModule.forRoot(),
    BrowserAnimationsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
