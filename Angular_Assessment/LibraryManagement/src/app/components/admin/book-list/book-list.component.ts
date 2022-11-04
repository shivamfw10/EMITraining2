import {Component, OnInit, ViewChild} from '@angular/core';

import { BookService } from 'src/app/shared_module/service/book.service';
import { Books } from 'src/app/module/material/books.model';
import {MatPaginator} from '@angular/material/paginator';
import { NotificationsService } from 'src/app/shared_module/service/notifications.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-book-list',
  templateUrl: './book-list.component.html',
  styleUrls: ['./book-list.component.css']
})
export class BookListComponent implements OnInit{
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  displayedColumns: string[] = ['id', 'title', 'author','category','quantity','action'];
  data:Books[]=[];
  searchText:any;
  constructor(private booksService:BookService,
    private toastr:NotificationsService,
    private route:Router){}
  ngOnInit():void{
    this.booksService.getBooks().subscribe(response=>{
      this.data=response;
    },error=>{
      console.log(error);
    })
  }
  public deleteBook(id:any):void{
    this.booksService.deleteBook(id).subscribe(res=>{
     {
      alert('Are you sure delete this data')
      this.toastr.showSuccess("Mesage","Successfully deleted");
      window.location.reload();
      }
    });
  }
  public viewBook(id:any){
    this.booksService.getBookById(id).subscribe(res=>{
      this.route.navigate(['/viewbook/',id])
    })
  }
}