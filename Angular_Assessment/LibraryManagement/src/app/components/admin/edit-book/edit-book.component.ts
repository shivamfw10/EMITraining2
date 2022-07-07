import { ActivatedRoute, Router } from '@angular/router';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

import { BookService } from 'src/app/shared_module/service/book.service';
import { Books } from 'src/app/module/material/books.model';
import { NotificationsService } from 'src/app/shared_module/service/notifications.service';

@Component({
  selector: 'app-edit-book',
  templateUrl: './edit-book.component.html',
  styleUrls: ['./edit-book.component.css']
})
export class EditBookComponent implements OnInit {
  book = new Books();
  editBook:FormGroup;
  constructor(private bookService:BookService,
    private formBuilder:FormBuilder,
    private route:ActivatedRoute,
    private router:Router,
    private toastr:NotificationsService) { }

  ngOnInit(): void {
    this.editBook = this.formBuilder.group({
      imageUrl:['',Validators.required],
      quantity:['',Validators.required]
    });
    this.getBook(this.route.snapshot.params['id']);
  }
  public getBook(id:any){
    this.bookService.getBookById(id).subscribe(res=>{
      this.book =res;
    },err=>{
      console.log(err);
    })
  }
  updateBook(editBook:any){
    this.bookService.updateBook(this.route.snapshot.params['id'],this.editBook.value).subscribe(res=>{
      const id = res['id'];
      
      this.toastr.showSuccess('Message','Record upated successfully');
      this.router.navigate([`/viewbook/${id}`]);
    },err=>{
      console.log(err)
    })
  }
  
}
