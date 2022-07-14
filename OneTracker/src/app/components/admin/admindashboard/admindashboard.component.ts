import { AfterViewInit, Component, OnInit, ViewChild } from '@angular/core';

import { BreakpointObserver } from '@angular/cdk/layout';
import { MatSidenav } from '@angular/material/sidenav';

@Component({
  selector: 'app-admindashboard',
  templateUrl: './admindashboard.component.html',
  styleUrls: ['./admindashboard.component.css']
})
export class AdmindashboardComponent implements AfterViewInit {
  @ViewChild(MatSidenav)
  sidenav!:MatSidenav;
  constructor(private observer:BreakpointObserver) { }


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

}
