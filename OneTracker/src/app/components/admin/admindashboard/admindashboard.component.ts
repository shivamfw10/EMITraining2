import { AfterViewInit, Component, OnInit, ViewChild } from '@angular/core';

import { AuthenticateService } from 'src/app/shared/service/authenticate.service';
import { BreakpointObserver } from '@angular/cdk/layout';
import { MatSidenav } from '@angular/material/sidenav';
import { Router } from '@angular/router';

@Component({
  selector: 'app-admindashboard',
  templateUrl: './admindashboard.component.html',
  styleUrls: ['./admindashboard.component.css']
})
export class AdmindashboardComponent implements AfterViewInit {
  @ViewChild(MatSidenav)
  sidenav!:MatSidenav;
  constructor(private observer:BreakpointObserver,public authService:AuthenticateService, private router:Router) { }


  ngAfterViewInit(): void {
      this.observer.observe(['(max-width:800px)']).subscribe((res)=>{
        if(res.matches){
          this.sidenav.mode='over';
          this.sidenav.close();
        }
        else{
          this.sidenav.mode='side';
          this.sidenav.open();
        }
      })
  }
  Logout(){
    this.authService.isAuthenticated=false;
    localStorage.removeItem('adminName');
    localStorage.removeItem('adminEmail');
    localStorage.removeItem('adminid');
    this.router.navigate([''])
    
}

}
