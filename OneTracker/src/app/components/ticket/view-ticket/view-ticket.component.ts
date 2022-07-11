import { ActivatedRoute, Router } from '@angular/router';
import { Component, OnInit } from '@angular/core';

import { Ticket } from 'src/app/shared/models/ticket.model';
import { TicketService } from 'src/app/shared/service/ticket.service';

@Component({
  selector: 'app-view-ticket',
  templateUrl: './view-ticket.component.html',
  styleUrls: ['./view-ticket.component.css']
})
export class ViewTicketComponent implements OnInit {
  ticket = new Ticket();
  constructor(private ticketService:TicketService,private router:Router, private route:ActivatedRoute) { }

  ngOnInit(): void {
    this.getTicket(this.route.snapshot.params['id']);
  }

  public getTicket(id:any)
  {
    this.ticketService.getTicketById(id).subscribe(response=>{
      this.ticket=response;
      console.log(this.ticket);
    })
  }
}
