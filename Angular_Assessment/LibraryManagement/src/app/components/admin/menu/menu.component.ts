import { Component, OnInit } from '@angular/core';

import { AuthenticateService } from 'src/app/shared_module/service/authenticate.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.css']
})
export class MenuComponent implements OnInit {
  name:any;
  id:any;
  userName:any;
  constructor(public authService:AuthenticateService, private router:Router) { }

  ngOnInit(): void {
    this.name = this.authService.isAuthenticated;
    this.userName = localStorage.getItem('adminName');
    this.id = localStorage.getItem('adminid');
  }
  LogOut(){
    this.authService.isAuthenticated=false;
    localStorage.clear();
    this.router.navigate(['']);
  }
}
