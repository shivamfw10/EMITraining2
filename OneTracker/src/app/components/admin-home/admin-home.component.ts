import { Component, OnInit } from '@angular/core';

import { Ticket } from 'src/app/core/models/ticket.model';
import { TicketService } from 'src/app/core/services/ticket.service';

@Component({
  selector: 'app-admin-home',
  templateUrl: './admin-home.component.html',
  styleUrls: ['./admin-home.component.css']
})
export class AdminHomeComponent implements OnInit {

  ticketData:Ticket[]=[];
  constructor(private ticketService:TicketService) { }

  ngOnInit(): void {
    this.ticketService.getTickets().subscribe((res)=>{
      this.ticketData=res;
    })
  }
  
  public countOpenTicket(data:any){
    let count=0;
    for(const element of data){
      if(element.status=='open'){
        count++;
      }
    }
    return count;
  }
  public ticketClose4hour(data:any){
    let count=0;
    for(const element of data){
      let age = element.ticketage.split(":");
      if(element.status=='close' && Number(age[0])<=4){
        count++;
      }
    }
    return count;
  }
  public ticketCrossed4hour(data:any){
    let count=0;
    for(const element of data){
      let age = element.ticketage.split(":");
      if(element.status=='open' && Number(age[0])>=4){
        count++;
      }
    }
    return count;
  }

}
