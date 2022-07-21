import { Component, OnInit, ViewChild } from '@angular/core';

import { Category } from 'src/app/core/utils/category';
import { Department } from 'src/app/core/utils/department';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { NotificationService } from 'src/app/core/services/notification.service';
import { Router } from '@angular/router';
import { SelectService } from 'src/app/core/services/select.service';
import { Subcategory } from 'src/app/core/utils/subcategory';
import { TicketService } from 'src/app/core/services/ticket.service';

@Component({
  selector: 'app-tickets',
  templateUrl: './tickets.component.html',
  styleUrls: ['./tickets.component.css']
})
export class TicketsComponent implements OnInit {
  departments: Department[];
  category: Category[];
  subcategory:Subcategory[];
  @ViewChild(MatPaginator) paginator!:MatPaginator;
  dataSource!:MatTableDataSource<any>;
  diff:any;
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
  router: any;
  interval:any
  constructor(private ticketService:TicketService,
    private notification:NotificationService,
    public route:Router,
    public selectService:SelectService) { }
  
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
        this.dataSource = new MatTableDataSource(res.filter((item)=>item.status==='open'));
        this.dataSource.paginator = this.paginator;
      },
      error: () => {
        this.notification.showError('Something went wrong','Error')
      }
    });
  }
  public applyFilter(event: Event):void {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }
 

  public calculateTicketAge(issueDate:Date){
    let d1 = new Date();
    let d2 = new Date(issueDate);
    let milliseconds = Math.floor(d1.getTime()-d2.getTime());
    
    let seconds = Math.floor(milliseconds/1000);
    let minutes = Math.floor(seconds/60);
    let hours = Math.floor((minutes/60));
    let days = Math.floor(hours/24);
        
    seconds = seconds % 60;
    minutes = minutes % 60;
    hours = hours%24;
   
    this.diff = days+'d '+hours+'hrs '+minutes+'min '+seconds+'sec ';
    return this.diff;
  }
  public viewTicket(id:any):void{
    this.ticketService.getTicketById(id).subscribe({
      next: (_res) => {
        this.router.navigate(['viewticket/',id]);
      },
      error: () => {
        this.notification.showError('Something went wrong','Error')
      }
    });
  }

}
