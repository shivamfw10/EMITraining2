import { Component, OnInit } from '@angular/core';

import { Ticket } from './../../shared/models/ticket.model';
import { TicketService } from 'src/app/shared/service/ticket.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  ticketData:Ticket[]=[];
  constructor(private ticketService:TicketService) { }

  ngOnInit(): void {
    this.ticketService.getTickets().subscribe((res)=>{
      this.ticketData=res;
    })
  }
  
  public countOpenTicket(data:any){
    let count=0;
    for(let i=0;i<data.length;i++){
      if(data[i].status=='open'){
        count++;
      }
    }
    return count;
  }
  public ticketClose4hour(data:any){
    let count=0;
    for(let i=0;i<data.length;i++){
      let age = data[i].ticketage.split(":");
      if(data[i].status=='close' && Number(age[0])<=4){
        count++;
      }
    }
    return count;
  }
  public ticketCrossed4hour(data:any){
    let count=0;
    for(let i=0;i<data.length;i++){
      let age = data[i].ticketage.split(":");
      if(data[i].status=='open' && Number(age[0])>=4){
        count++;
      }
    }
    return count;
  }
}
