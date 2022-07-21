import { Component, OnInit } from '@angular/core';

import { AuthenticateService } from 'src/app/core/services/authenticate.service';
import { Router } from '@angular/router';
import { UserService } from 'src/app/core/services/user.service';

@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.css']
})
export class SidebarComponent implements OnInit{
  emailId:string;
  userName:string;
  userEmail:string;
  
  constructor(public authService:AuthenticateService, 
    private router:Router,
    public userService:UserService) { 
    }
  ngOnInit(): void {
      this.getUserName();
  }
  public getUserName():void{
    this.emailId= this.authService.data.email;
    if (this.authService.isAuthenticated) {
      this.userService.getUsers().subscribe({
        next: (res) => {
          res.forEach((el) => {
            if (el.email == this.emailId){
              this.userName=el.firstName;
              this.userEmail=el.email;
            }
          });
        },
      });
    }
  }
  public Logout():void{
      this.authService.isAuthenticated=false;
      this.router.navigate(['']);
      window.location.reload();
  }
}
