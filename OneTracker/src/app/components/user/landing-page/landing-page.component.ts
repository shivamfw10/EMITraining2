import { Component, OnInit, ViewChild } from '@angular/core';

import {MatPaginator} from '@angular/material/paginator';
import {MatTableDataSource} from '@angular/material/table';
import { Ticket } from 'src/app/shared/models/ticket.model';
import { TicketService } from 'src/app/shared/service/ticket.service';

@Component({
  selector: 'app-landing-page',
  templateUrl: './landing-page.component.html',
  styleUrls: ['./landing-page.component.css']
})
export class LandingPageComponent implements OnInit {

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  dataSource!: MatTableDataSource<any>;
  displayedColumns: string[] = ['id', 
  'department',
  'category',
  'subCategory',
  'status',
  'customer',
  'issueTime',
  'ticketage',
  'lastModifiedDate',
  'rca'];
  data:Ticket[]=[];
  constructor(private ticketService:TicketService){}
  // ngOnInit(): void {
  //   this.ticketService.getTickets().subscribe(response=>{
  //     this.data=response;
  //     console.log(this.data);
  //     console.log(this.data.length)
  //   },err=>{
  //     console.log(err);
  //   })
  // }

ngOnInit(): void {
this.ticketService.getTickets().subscribe({
next: (res) => {
  this.dataSource = new MatTableDataSource(res);

this.dataSource.paginator = this.paginator;
},
});
}
}

