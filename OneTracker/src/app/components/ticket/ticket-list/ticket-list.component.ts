import { Component, OnInit, ViewChild } from '@angular/core';

import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { NotificationService } from 'src/app/shared/service/notification.service';
import { TicketService } from 'src/app/shared/service/ticket.service';

@Component({
  selector: 'app-ticket-list',
  templateUrl: './ticket-list.component.html',
  styleUrls: ['./ticket-list.component.css']
})
export class TicketListComponent implements OnInit {

  @ViewChild(MatPaginator) paginator!:MatPaginator;
  dataSource!:MatTableDataSource<any>;
  displayedColumns:string[]=[
    'no',
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
  constructor(private ticketService:TicketService,private notification:NotificationService) { }
  
  ngOnInit(): void {
    this.ticketService.getTickets().subscribe({
      next: (res) => {
        this.dataSource = new MatTableDataSource(res);
        this.dataSource.paginator = this.paginator;
      },
    });
  }

  public viewTicket(id:any){
    
  }
  public deleteTicket(id:any){

      this.ticketService.deleteTicket(id).subscribe(res=>{
        alert('Are you sure delete this data')
        this.notification.showSuccess("Mesage","Successfully deleted");
      });
      this.getAllTickets();
  }
  public getAllTickets(){
    this.ticketService.getTickets().subscribe({
      next: (res) => {
        this.dataSource = new MatTableDataSource(res);
        this.dataSource.paginator = this.paginator;
      },
    });
  }
  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }

}
