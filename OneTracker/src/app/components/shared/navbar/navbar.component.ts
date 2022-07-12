import { Component, OnInit } from '@angular/core';

import { AuthenticateService } from 'src/app/shared/service/authenticate.service';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {
  searchText:any;
  constructor(public authService:AuthenticateService) { }

  ngOnInit(): void {
  }

}
