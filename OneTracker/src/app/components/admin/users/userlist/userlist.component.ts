import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';

import { AdduserComponent } from '../adduser/adduser.component';
import { MatDialog } from '@angular/material/dialog';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { NotificationService } from 'src/app/shared/service/notification.service';
import { Router } from '@angular/router';
import { UpdateuserComponent } from '../updateuser/updateuser.component';
import { UserService } from 'src/app/shared/service/user.service';
import { ViewuserComponent } from './../viewuser/viewuser.component';

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
    public matDialog:MatDialog,
    private el: ElementRef) { }

  ngOnInit(): void {
    this.userService.getUsers().subscribe({
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

  public getAllUsers(){
    this.userService.getUsers().subscribe({
      next: (res) => {
        this.dataSource = new MatTableDataSource(res);
        this.dataSource.paginator = this.paginator;
      },
    });
  }
  
  public addUser(){
    this.matDialog.open(AdduserComponent,{
        width: '500px'
      });
    }
    
  public updateUser(element:any){
    this.matDialog.open(UpdateuserComponent,{
      width:'470px',
      data:element,
    }).afterClosed().subscribe(val=>{
      this.getAllUsers();
    })
  }
  
  public viewUser(element:any){
    this.matDialog.open(ViewuserComponent,{
      width:'470px',
      data:element,
    }).afterClosed().subscribe(val=>{
      this.getAllUsers();
    })
  }
  
  public deleteUser(id:any){
    var proceed = confirm("Are you sure delete this data?");
    if(proceed){
      this.userService.deleteUser(id).subscribe(res=>{
        this.notification.showSuccess("Mesage","Successfully deleted");
      });
      this.getAllUsers();
    } else {
    }
  }
 

}
