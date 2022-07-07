import {Component, OnInit, ViewChild} from '@angular/core';

import {MatPaginator} from '@angular/material/paginator';
import {MatTableDataSource} from '@angular/material/table';
import { UserService } from 'src/app/shared_module/service/user.service';
import { Users } from 'src/app/module/material/users.model';

@Component({
  selector: 'app-user-list',
  templateUrl: './user-list.component.html',
  styleUrls: ['./user-list.component.css']
})
export class UserListComponent implements OnInit {
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  displayedColumns: string[] = ['userId', 'userName', 'userEmail','userBooks','pickupDate','returnDate'];
  data:Users[]=[];
  searchText:any;
  constructor(private userService:UserService){}
  ngOnInit():void{
  this.userService.getUsers().subscribe(response=>{
    this.data = response;
  },error=>{
    console.log(error)
  })
 }

}

