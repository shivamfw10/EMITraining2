import { ActivatedRoute, Router } from '@angular/router';
import { Component, OnInit } from '@angular/core';

import { BookService } from 'src/app/shared_module/service/book.service';
import { Books } from 'src/app/module/material/books.model';

@Component({
  selector: 'app-view-book',
  templateUrl: './view-book.component.html',
  styleUrls: ['./view-book.component.css']
})
export class ViewBookComponent implements OnInit {
  book = new Books();
  constructor(private bookService:BookService, private route:ActivatedRoute) { }

  ngOnInit(): void {
    this.getBook(this.route.snapshot.params['id']);
  }
  public getBook(id:any){
    this.bookService.getBookById(id).subscribe(res=>{
      this.book=res;
    },error=>{
      console.log(error);
    })
  }

}
