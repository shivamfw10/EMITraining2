import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';

import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { NotificationService } from 'src/app/shared/service/notification.service';
import { UserService } from 'src/app/shared/service/user.service';

@Component({
  selector: 'app-userlist',
  templateUrl: './userlist.component.html',
  styleUrls: ['./userlist.component.css']
})
export class UserlistComponent implements OnInit{
  @ViewChild(MatPaginator) paginator!:MatPaginator;
  dataSource!:MatTableDataSource<any>;
  displayedColumns:string[]=[
    'id',
    'name',
    'email',
    'status',
    'role',
    'action'
  ]
  constructor(private userService:UserService,
    private notification:NotificationService,
    private el: ElementRef) { }

  ngOnInit(): void {
    this.userService.getUsers().subscribe({
      next: (res) => {
        this.dataSource = new MatTableDataSource(res);
        this.dataSource.paginator = this.paginator;
      },
    });
  }
  public viewUser(id:any){
    
  }
  public deleteUser(id:any){
    var proceed = confirm("Are you sure delete this data?");
    if(proceed){
      this.userService.deleteUser(id).subscribe(res=>{
        this.notification.showSuccess("Mesage","Successfully deleted");
      });
    } else {
    }
    // window.location.reload();
  }
  
}
