import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
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
  constructor(private http:HttpClient, private router:Router) { }
  
  public authenticateEmployee(data:any)
  {
    return this.http.get(apiUrl).subscribe(response=>{
      this.user=response;
      this.data=data;
      this.authenticateUser();
      this.navigateUser();
    })
  }

  authenticateUser()
  {
    this.response=(this.user.find((x:any)=>{
      return x.email==this.data.email && x.password==this.data.password

    }))
  }

navigateUser(){
  if(this.response)
  {
    this.checkRole();
  }
  else{
    alert ("Invalid Credential");
  }
}
checkRole()
{
  this.isAuthenticated=true;
  if(this.response.role==='admin')
  {
    this.isAdmin=true;
    this.isAuthenticated=true;
    this.router.navigate(['dashboard']);
      localStorage.setItem('adminid',this.response.id);
      localStorage.setItem('adminName',this.response.firstName);
  }
  else if(this.response.role==='user')
  {
    this.isUser=true;
    this.isAuthenticated=true;
    this.router.navigate(['landingpage']);
    localStorage.setItem('userid',this.response.id);
    localStorage.setItem('firstName',this.response.firstName);
    localStorage.setItem('lastName',this.response.lastName);
    localStorage.setItem('email',this.response.email);
  }
  

  else
  {
    alert ("Invalis user");
  }
}
}
