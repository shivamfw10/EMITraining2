import { ActivatedRoute, Router } from '@angular/router';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';

import { Ticket } from 'src/app/shared/models/ticket.model';
import { TicketService } from 'src/app/shared/service/ticket.service';

@Component({
  selector: 'app-update-ticket',
  templateUrl: './update-ticket.component.html',
  styleUrls: ['./update-ticket.component.css']
})
export class UpdateTicketComponent implements OnInit {
  ticket = new Ticket();
  ticketForm:FormGroup;
  disableSelect = new FormControl(false);
  constructor(
    private ticketService:TicketService,
     private router:Router,
     private formBuilder:FormBuilder, 
     private route:ActivatedRoute) { }

  ngOnInit(): void {
    this.ticketForm=this.formBuilder.group({
      ticketid:['',Validators.required],
      department:['',Validators.required],
      category:['',Validators.required],
      subCategory:['',Validators.required],
      customer:['',Validators.required],
      issueTime:['',Validators.required],
      subject:['',Validators.required],
      issueDescription:['',Validators.required],
      emailId:['',Validators.required],
      escEmail:['',Validators.required], 
      teamLink:['',Validators.required],
      lastModifiedDate:['',Validators.required]
    });
    this.getTicket(this.route.snapshot.params['id']);
    this.ticketForm.get('department').disable();
    this.ticketForm.get('category').disable();
    this.ticketForm.get('subCategory').disable();
    this.ticketForm.get('customer').disable();
    this.ticketForm.get('issueTime').disable();
    this.ticketForm.get('subject').disable();
    this.ticketForm.get('department').disable();
    this.ticketForm.get('escEmail').disable();
   
  }

  public getTicket(id:any)
  {
    this.ticketService.getTicketById(id).subscribe(response=>{
      this.ticket=response;
      console.log(this.ticket);
    })
    
  }
  
  OnFormSubmit(ticketForm:any){
    this.ticketService.EditTicket(this.route.snapshot.params['id'],this.ticketForm.value).subscribe(response=>{
     const id=response['id'];
     this.router.navigate(['/landingpage']);
    },error=>{
     console.log(error);
    })
  }
}
