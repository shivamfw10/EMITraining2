import { ActivatedRoute, Router } from '@angular/router';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';

import { NotificationService } from 'src/app/core/services/notification.service';
import { Ticket } from 'src/app/core/models/ticket.model';
import { TicketService } from 'src/app/core/services/ticket.service';

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
     private route:ActivatedRoute,
     private toastrService:NotificationService) { }

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

  public getTicket(id:any):void{
    this.ticketService.getTicketById(id).subscribe(response=>{
      this.ticket=response;
      console.log(this.ticket);
    }) 
  }
  
 public OnFormSubmit(_ticketForm:any):void{
    this.ticketService.EditTicket(this.route.snapshot.params['id'],this.ticketForm.value).subscribe({
      next: (_res) => {
        this.toastrService.showSuccess('Detail Updated Successfully','Message');
        this.router.navigate(['/landingpage']);
      },
      error: () => {
        this.toastrService.showError('Something went wrong','Error')
      }
    })
 }
}
