import { Component, OnInit } from '@angular/core';

import { ReqbookService } from 'src/app/shared_module/service/reqbook.service';
import { Requestedbook } from 'src/app/module/requestedbook.model';

@Component({
  selector: 'app-view-cart',
  templateUrl: './view-cart.component.html',
  styleUrls: ['./view-cart.component.css']
})
export class ViewCartComponent implements OnInit {
  reqBookData:any;
  useremail = localStorage.getItem('email');
  constructor(private reqBookService:ReqbookService) { }

  ngOnInit(): void {
    this.reqBookService.getBooks().subscribe(response=>{
      this.reqBookData = response;
    },error=>{
      console.log(error)
    })
  }

}
