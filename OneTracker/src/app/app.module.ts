import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { AddTicketComponent } from './components/ticket/add-ticket/add-ticket.component';
import { AdduserComponent } from './components/admin/users/adduser/adduser.component';
import { AdmindashboardComponent } from './components/admin/admindashboard/admindashboard.component';
import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { BrowserModule } from '@angular/platform-browser';
import { CustomPipe } from './shared/pipes/custom.pipe';
import { DashboardComponent } from './components/user/dashboard/dashboard.component';
import { HeaderComponent } from './components/shared/header/header.component';
import { HomeComponent } from './components/home/home.component';
import { HttpClientModule } from '@angular/common/http';
import { LandingPageComponent } from './components/user/landing-page/landing-page.component';
import { LoginComponent } from './components/shared/login/login.component';
import { MaterialModule } from './shared/material/material.module';
import { NavbarComponent } from './components/shared/navbar/navbar.component';
import { Ng2SearchPipeModule } from 'ng2-search-filter';
import { NgModule } from '@angular/core';
import { PageNotFoundComponent } from './components/shared/page-not-found/page-not-found.component';
import { ToastrModule } from 'ngx-toastr';
import { UpdateTicketComponent } from './components/ticket/update-ticket/update-ticket.component';
import { UpdateuserComponent } from './components/admin/users/updateuser/updateuser.component';
import { UserlistComponent } from './components/admin/users/userlist/userlist.component';
import { ViewTicketComponent } from './components/ticket/view-ticket/view-ticket.component';
import { SidebarComponent } from './components/admin/sidebar/sidebar.component';
import { TicketListComponent } from './components/ticket/ticket-list/ticket-list.component';
import { SelectComponent } from './select/select.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    LoginComponent,
    AdmindashboardComponent,
    PageNotFoundComponent,
    AddTicketComponent,
    ViewTicketComponent,
    UpdateTicketComponent,
    NavbarComponent,
    LandingPageComponent,
    DashboardComponent,
    UserlistComponent,
    AdduserComponent,
    UpdateuserComponent,
    HeaderComponent,
    CustomPipe,
    SidebarComponent,
    TicketListComponent,
    SelectComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MaterialModule,
    ReactiveFormsModule,
    FormsModule,
    HttpClientModule,
    Ng2SearchPipeModule,
    ToastrModule.forRoot()
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
