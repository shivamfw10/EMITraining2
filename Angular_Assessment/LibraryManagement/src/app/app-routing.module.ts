import { RouterModule, Routes } from '@angular/router';

import { AddBookComponent } from './components/admin/add-book/add-book.component';
import { AuthguardGuard } from './shared_module/service/authguard.guard';
import { BookListComponent } from './components/admin/book-list/book-list.component';
import { DashboardComponent } from './components/admin/dashboard/dashboard.component';
import { EditBookComponent } from './components/admin/edit-book/edit-book.component';
import { LandingPageComponent } from './components/user/landing-page/landing-page.component';
import { LoginComponent } from './components/shared/login/login.component';
import { NgModule } from '@angular/core';
import { PageNotFoundComponent } from './components/shared/page-not-found/page-not-found.component';
import { RegistrationComponent } from './components/shared/registration/registration.component';
import { UserListComponent } from './components/admin/user-list/user-list.component';
import { ViewBookComponent } from './components/admin/view-book/view-book.component';
import { ViewCartComponent } from './components/user/view-cart/view-cart.component';

const routes: Routes = [
  {path:'',component:LoginComponent},
  {path:'signup',component:RegistrationComponent},
 {path:'dashboard',component:DashboardComponent},
 {path:'landingpage',component:LandingPageComponent,canActivate:[AuthguardGuard]},

 {path:'books',component:BookListComponent},
  {path:'addbook',component:AddBookComponent},
 {path:'viewbook/:id',component:ViewBookComponent},
 {path:'viewbook/:id/edit/:id',component:EditBookComponent},
 {path:'users',component:UserListComponent},
 {path:'viewcart',component:ViewCartComponent,canActivate:[AuthguardGuard]},
 {path:'**',component:PageNotFoundComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
