import { Component, OnInit } from '@angular/core';

import { BookService } from 'src/app/shared_module/service/book.service';
import { Books } from 'src/app/module/material/books.model';
import { UserService } from 'src/app/shared_module/service/user.service';
import { Users } from 'src/app/module/material/users.model';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {
  userData:Users[]=[];
  bookData:Books[]=[];
  today = new Date();
  constructor(private userService:UserService,private bookService:BookService) { }

  ngOnInit(): void {
    this.bookService.getBooks().subscribe(res=>{
      this.bookData=res;
    },err=>{
      console.log(err)
    }),
    this.userService.getUsers().subscribe(res=>{
      this.userData=res;
    },err=>{
      console.log(err)
    })
 
  }
  public userCount(data:any){
    let count:number =1;
    for(let i=0;i<data.length;i++){
      if(data[i].role=="user"){
        count++;
      }
    }
    return count;
  }
}
