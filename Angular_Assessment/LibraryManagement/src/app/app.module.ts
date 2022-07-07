import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { AddBookComponent } from './components/admin/add-book/add-book.component';
import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { BookListComponent } from './components/admin/book-list/book-list.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { BrowserModule } from '@angular/platform-browser';
import { DashboardComponent } from './components/admin/dashboard/dashboard.component';
import { EditBookComponent } from './components/admin/edit-book/edit-book.component';
import { HttpClientModule } from '@angular/common/http';
import { LandingPageComponent } from './components/user/landing-page/landing-page.component';
import { LoginComponent } from './components/shared/login/login.component';
import { MaterialModule } from './module/material/material.module';
import { MenuComponent } from './components/admin/menu/menu.component';
import { NavbarComponent } from './components/shared/navbar/navbar.component';
import { Ng2SearchPipeModule } from 'ng2-search-filter';
import { NgModule } from '@angular/core';
import { PageNotFoundComponent } from './components/shared/page-not-found/page-not-found.component';
import { RegistrationComponent } from './components/shared/registration/registration.component';
import { ToastrModule } from 'ngx-toastr';
import { UserListComponent } from './components/admin/user-list/user-list.component';
import { ViewBookComponent } from './components/admin/view-book/view-book.component';
import { ViewCartComponent } from './components/user/view-cart/view-cart.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    RegistrationComponent,
    AddBookComponent,
    EditBookComponent,
    BookListComponent,
    UserListComponent,
    ViewBookComponent,
    NavbarComponent,
    ViewCartComponent,
    LandingPageComponent,
    PageNotFoundComponent,
    DashboardComponent,
    MenuComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MaterialModule,
    ReactiveFormsModule,
    HttpClientModule,
    FormsModule,
    Ng2SearchPipeModule,
    ToastrModule.forRoot()
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
