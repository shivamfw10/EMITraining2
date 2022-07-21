import { Component, OnInit, ViewChild } from '@angular/core';

import { MatDialog } from '@angular/material/dialog';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { NotificationService } from 'src/app/core/services/notification.service';
import { TicketService } from 'src/app/core/services/ticket.service';
import { ViewTicketComponent } from './view-ticket/view-ticket.component';

@Component({
  selector: 'app-ticket-list',
  templateUrl: './ticket-list.component.html',
  styleUrls: ['./ticket-list.component.css']
})
export class TicketListComponent implements OnInit {
   
  diff:any;
  interval:any;
  @ViewChild(MatPaginator) paginator!:MatPaginator;
  dataSource!:MatTableDataSource<any>;
  displayedColumns:string[]=[
    // 'no',
    'ticketid',
    'department',
    'category',
    'subcategory',
    'status',
    'customer',
    'issueTime',
    'age',
    'lastModified',
    'action'
  ]
  constructor(private ticketService:TicketService,
    private notification:NotificationService,
    public matDialog:MatDialog) { }
  
  ngOnInit(): void {
    this.getAllTickets();
    this.interval = setInterval(() => { 
      this.getAllTickets(); 
    }, 1000);
  }

  public deleteTicket(id:any):void{
      this.ticketService.deleteTicket(id).subscribe({
        next: (_res) => {
          alert('Are you sure delete this data');
          this.notification.showSuccess('Ticket Deleted Successfully','Message');
        },
        error: () => {
          this.notification.showError('Something went wrong','Error')
        }
      });
      this.getAllTickets();
  }
  public getAllTickets():void{
    this.ticketService.getTickets().subscribe({
      next: (res) => {
        this.dataSource = new MatTableDataSource(res);
        this.dataSource.paginator = this.paginator;
      },
      error: () => {
        this.notification.showError('Something went wrong','Error')
      }
    });
  }
public applyFilter(event: Event):void{
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }
  public calculateTicketAge(issueDate:Date){
    let d1 = new Date();
    let d2 = new Date(issueDate);
    let milliseconds = Math.floor(d1.getTime()-d2.getTime());
    
    let seconds = Math.floor(milliseconds/1000);
    let minutes = Math.floor((seconds/60));
    let hours = Math.floor((minutes/60));
    let days = Math.floor(hours/24);
        
    seconds = seconds % 60;
    minutes = minutes % 60;
    hours = hours%24;
   
    this.diff = days+'d '+hours+'hrs '+minutes+'min '+seconds+'sec ';
    setInterval(()=>{
      return this.diff;
    },5000);
    return this.diff;
  }
 public viewTicket(element:any):void{
  this.matDialog.open(ViewTicketComponent,{
    width:'800px',
    data:element,
  }).afterClosed().subscribe(_val=>{
    this.getAllTickets();
  })
 }
}
