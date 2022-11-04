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
  bookQty:any;
  counter=0;
  count:any;
  
  currentDate = new Date();
  day = this.currentDate.getDate();
  month = this.currentDate.getMonth()+1;
  year = this.currentDate.getFullYear();
  returnDate = (this.day + 3 + '/' + this.month + '/' + this.year);
  pickedupdate = (this.day + '/' + this.month + '/' + this.year);
  
  userId = localStorage.getItem('userid');
  useremail = localStorage.getItem('email');
  username = localStorage.getItem('firstName')+' '+localStorage.getItem('lastName');
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
    
  
  }
  addDataCart(id:any){
  this.requestBook.getBooks().subscribe(res=>{
      if(this.requestCount(this.useremail,res)<3){
        this.bookService.getBookById(id).subscribe(resp=>{
          this.bookService.updateBook(id,resp.quantity-1).subscribe(response=>{
            console.log(response)
          });
          this.requestBook.addRequestedBook(this.requestedBookPost(resp.title,resp.author,resp.category,resp.imageUrl,this.useremail,this.username,this.pickedupdate,this.returnDate)).subscribe(res=>{
            this.toastrService.showSuccess('Book request added successfully', `${"Return Date is "+this.returnDate}`);
            this.count++
          });
        });
      }
      else{
        this.toastrService.showWarning("You exceed the limit of book request","falied")
      }
    })
  } 
  requestCount(email:any,data:any){
    let count=0;
    for(let i=0;i<data.length;i++){
      if(data[i].userEmail==email){
        count++;
      }
    }
    return count;
  }

  requestedBookPost(title:string,author:string,
    category:string,imageUrl:string,
    userEmail:string,username:string,pickedupDate:string,returnDate:string){
    return {title:title,author:author,category:category,
            quantity:1,imageUrl:imageUrl,userEmail:userEmail,
          username:username,pickupDate:pickedupDate,returnDate:returnDate}
  }
}