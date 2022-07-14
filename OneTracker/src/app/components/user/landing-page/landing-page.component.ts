import { Component, OnChanges, OnInit, SimpleChanges, ViewChild } from '@angular/core';

import {MatPaginator} from '@angular/material/paginator';
import {MatTableDataSource} from '@angular/material/table';
import { Subject } from 'rxjs';
import { Ticket } from 'src/app/shared/models/ticket.model';
import { TicketService } from 'src/app/shared/service/ticket.service';

@Component({
  selector: 'app-landing-page',
  templateUrl: './landing-page.component.html',
  styleUrls: ['./landing-page.component.css']
})
export class LandingPageComponent implements OnInit, OnChanges {
  searchText:any;

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
  data:any;
  constructor(private ticketService:TicketService,private reciveddata:TicketService){
  
    
  }
ngOnInit(): void {
  this.ticketService.getTickets().subscribe(response=>{
    this.data=response;
  })
  
  // this.ticketService.getTickets().subscribe({
  // next: (res) => {
  //   this.dataSource = new MatTableDataSource(res);
  //   this.dataSource.paginator = this.paginator;
  //   },
  //   });
  // }
}
ngOnChanges(): void {
  this.reciveddata.subject.subscribe(response=>{
    this.searchText=response;
    console.log(this.searchText);
  });
}
}

