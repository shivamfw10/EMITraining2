import { Component, OnInit } from '@angular/core';

import { AuthenticateService } from 'src/app/shared/service/authenticate.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.css']
})
export class SidebarComponent implements OnInit {
  name:any=localStorage.getItem('adminName');
  email:any=localStorage.getItem('adminEmail');
  constructor(public authService:AuthenticateService, private router:Router) { }
  
  ngOnInit(): void {
  }
  Logout(){
      this.authService.isAuthenticated=false;
      localStorage.removeItem('adminName');
      localStorage.removeItem('adminEmail');
      localStorage.removeItem('adminid');
      this.router.navigate([''])
      
  }
}
