import { Component, OnInit } from '@angular/core';

import { BookService } from 'src/app/shared_module/service/book.service';
import { Books } from 'src/app/module/material/books.model';
import { NotificationsService } from 'src/app/shared_module/service/notifications.service';
import { ReqbookService } from 'src/app/shared_module/service/reqbook.service';
import { Requestedbook } from './../../../module/requestedbook.model';
import { UserService } from 'src/app/shared_module/service/user.service';

@Component({
  selector: 'app-landing-page',
  templateUrl: './landing-page.component.html',
  styleUrls: ['./landing-page.component.css']
})
export class LandingPageComponent implements OnInit {
  cartdata:any;
  data:any;
  searchText:any;
  userId:any;
  username:any;
  bookQty:any;
  counter=0;
  
  currentDate = new Date();
  day = this.currentDate.getDate();
  month = this.currentDate.getMonth()+1;
  year = this.currentDate.getFullYear();
  returnDate = (this.day + 3 + '/' + this.month + '/' + this.year);
  
  constructor(
    private bookService:BookService,
    private requestBook:ReqbookService, 
    private userService:UserService,
    private toastrService:NotificationsService) { }
  ngOnInit(): void {
    this.bookService.getBooks().subscribe(response=>{
      this.data = response;
    },error=>{
      console.log(error)
    })
    this.userId = localStorage.getItem('userid');
    this.username = localStorage.getItem('email');
  
  }
  
  addDataCart(id:any){
    if(this.counter<3){
      this.bookService.getBookById(id).subscribe(response=>{
        this.requestBook.addRequestedBook(response).subscribe(res=>{
          this.toastrService.showSuccess('Book request added successfully', `${"Return Date is "+this.returnDate}`);
          this.counter++
        });
      });
    }
    else{
      this.toastrService.showWarning("You exceed the limit of book request","falied")
    }
  } 
}