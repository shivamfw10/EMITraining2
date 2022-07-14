import { Component, OnChanges, OnInit, SimpleChanges } from '@angular/core';

import { AuthenticateService } from 'src/app/shared/service/authenticate.service';
import { TicketService } from 'src/app/shared/service/ticket.service';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit, OnChanges {
 searchText:any;
  constructor(public authService:AuthenticateService,private datashareservice:TicketService) { }
  ngOnInit(): void {
    // this.datashareservice.searchdata(this.searchText);
  }
  ngOnChanges(): void {
  
    this.datashareservice.searchdata(this.searchText);
    location.reload();
  }
  onClick(){
    // this.datashareservice.searchdata(this.searchText);
  }


}
