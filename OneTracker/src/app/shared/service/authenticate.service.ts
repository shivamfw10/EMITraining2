import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { NotificationService } from './notification.service';
import { Router } from '@angular/router';
import { environment } from 'src/environments/environment';

const apiUrl = environment.userUrl;
@Injectable({
  providedIn: 'root'
})
export class AuthenticateService {
  user:any;
  isAuthenticated=false;
  isAdmin=false;
  isUser=false;
  response:any;
  data:any;
  constructor(private http:HttpClient, private router:Router,private toastr:NotificationService) { }
  
  public authenticateUser(data:any){
    return this.http.get(apiUrl).subscribe(response=>{
      this.user=response;
      this.data=data;
      this.authentication();
      this.navigateUser();
    })
  }
  
  authentication(){
    this.response=(this.user.find((x:any)=>{
      return x.email==this.data.email && x.password==this.data.password

    }))
  }
  navigateUser(){
    if(this.response){
      this.checkRole();
      this.toastr.showSuccess('Congratulation','Successfull Logged In');
    }
    else{
      this.toastr.showWarning('Try again', `Invalid Credential`);
    }
  }
  checkRole()
  {
    this.isAuthenticated=true;
    if(this.response.role==='admin')
    {
      this.isAdmin=true;
      this.isAuthenticated=true;
      this.router.navigate(['dashboard/home']);
        localStorage.setItem('adminid',this.response.id);
        localStorage.setItem('adminName',this.response.firstName);
        localStorage.setItem('adminEmail',this.response.email);
    }
    else if(this.response.role==='user'){
      this.isUser=true;
      this.isAuthenticated=true;
      this.router.navigate(['landingpage']);
      localStorage.setItem('userid',this.response.id);
      localStorage.setItem('firstName',this.response.firstName);
      localStorage.setItem('lastName',this.response.lastName);
      localStorage.setItem('email',this.response.email);
    }
    
    else{
      this.toastr.showError('Message','Invalid user');
    }
  }
  
}
