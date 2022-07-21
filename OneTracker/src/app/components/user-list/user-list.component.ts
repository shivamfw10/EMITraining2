import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';

import { AdduserComponent } from './adduser/adduser.component';
import { MatDialog } from '@angular/material/dialog';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { NotificationService } from 'src/app/core/services/notification.service';
import { UpdateuserComponent } from './updateuser/updateuser.component';
import { UserService } from 'src/app/core/services/user.service';
import { ViewuserComponent } from './viewuser/viewuser.component';

@Component({
  selector: 'app-user-list',
  templateUrl: './user-list.component.html',
  styleUrls: ['./user-list.component.css']
})
export class UserListComponent implements OnInit {

  statusRes:any="Active";

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
    this.getAllUsers();
  }
  applyFilter(event: Event):void{
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }

  public getAllUsers():void{
    this.userService.getUsers().subscribe({
      next: (res) => {
        this.dataSource = new MatTableDataSource(res);
        this.dataSource.paginator = this.paginator;
      },
      error: () => {
        this.notification.showError('Something went wrong','Error');
      }
    });
  }
  
  public addUser():void{
    this.matDialog.open(AdduserComponent,{
        width: '500px'
      });
    }
    
  public updateUser(element:any):void{
    this.matDialog.open(UpdateuserComponent,{
      width:'470px',
      data:element,
    }).afterClosed().subscribe(_val=>{
      this.getAllUsers();
    })
  }
  
  public viewUser(element:any):void{
    this.matDialog.open(ViewuserComponent,{
      width:'470px',
      data:element,
    }).afterClosed().subscribe(_val=>{
      this.getAllUsers();
    })
  }
  
  public deleteUser(id:any):void{
    let proceed = confirm("Are you sure delete this data?");
    if(proceed){
      this.userService.deleteUser(id).subscribe(_res=>{
        this.notification.showSuccess("Mesage","Successfully deleted");
      });
      this.getAllUsers();
    }
  }
 

}
