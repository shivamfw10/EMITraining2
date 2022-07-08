import {Component, OnInit, ViewChild} from '@angular/core';

import {MatPaginator} from '@angular/material/paginator';
import { ReqbookService } from 'src/app/shared_module/service/reqbook.service';
import { Requestedbook } from './../../../module/requestedbook.model';

@Component({
  selector: 'app-requestedbook',
  templateUrl: './requestedbook.component.html',
  styleUrls: ['./requestedbook.component.css']
})
export class RequestedbookComponent implements OnInit {
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  displayedColumns: string[] = ['id', 'userName', 'userEmail','quantity','pickupDate','returnDate'];
  data:Requestedbook[]=[];
  searchText:any;
  constructor(private requestBookService:ReqbookService){}
  ngOnInit():void{
  this.requestBookService.getBooks().subscribe(response=>{
    this.data = response;
  },error=>{
    console.log(error)
  })
 }

}
