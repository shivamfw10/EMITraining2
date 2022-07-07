import { Component, OnInit } from '@angular/core';

import { AuthenticateService } from 'src/app/shared_module/service/authenticate.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {
  hidden = false;
  name:any;
  userName:any;
  id:any;
  toggleBadgeVisibility() {
    this.hidden = !this.hidden;
  }
  constructor(public authService:AuthenticateService, private router:Router) { }

  ngOnInit(): void {
    this.name = this.authService.isAuthenticated;
    this.userName = localStorage.getItem('userName');
    this.id = localStorage.getItem('userid');
  }

  LogOut(){
    this.authService.isAuthenticated=false;
    localStorage.clear();
    this.router.navigate(['']);
    
  }
}
