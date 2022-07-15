import { Component, OnInit } from '@angular/core';

import { AuthenticateService } from 'src/app/shared/service/authenticate.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.css']
})
export class SidebarComponent implements OnInit {
  constructor(public authService:AuthenticateService, private router:Router) { }

  ngOnInit(): void {
  }
  
}
