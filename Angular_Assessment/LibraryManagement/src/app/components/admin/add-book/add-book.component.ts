import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

import { BookService } from 'src/app/shared_module/service/book.service';
import { NotificationsService } from 'src/app/shared_module/service/notifications.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-add-book',
  templateUrl: './add-book.component.html',
  styleUrls: ['./add-book.component.css']
})
export class AddBookComponent implements OnInit {
  formBook:FormGroup;
  constructor(private bookService:BookService, private formBuiler:FormBuilder,
    private toastr:NotificationsService,
    private router:Router) { }

  ngOnInit(): void {
    this.formBook=this.formBuiler.group({
      title:['',Validators.required],
      author:['',Validators.required],
      category:['',Validators.required],
      quantity:[,Validators.required],
      imageUrl:['',Validators.required]
    })
  }
  AddBook(formBook:any){
    this.bookService.addBook(formBook).subscribe(response=>{
      const id = response['id'];
      this.toastr.showSuccess('Message','Book added successfully');
      this.router.navigate(['/books']);
    },error=>{
      console.log(error);
    })
  }

}
