import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, NgForm, Validators } from '@angular/forms';

import { Category } from 'src/app/core/utils/category';
import { Department } from 'src/app/core/utils/department';
import { NotificationService } from 'src/app/core/services/notification.service';
import { Router } from '@angular/router';
import { SelectService } from 'src/app/core/services/select.service';
import { Subcategory } from 'src/app/core/utils/subcategory';
import { TicketService } from 'src/app/core/services/ticket.service';

@Component({
  selector: 'app-add-ticket',
  templateUrl: './add-ticket.component.html',
  styleUrls: ['./add-ticket.component.css'],
})
export class AddTicketComponent implements OnInit {
  ticketForm: FormGroup;
  departments: Department[];
  category: Category[];
  subcategory:Subcategory[];
  constructor(
    private ticketService: TicketService,
    private formBuilder: FormBuilder,
    private selectService:SelectService,
    private toastrService:NotificationService,
    private router:Router
  ) {}

  ngOnInit(): void {
    this.departments = this.selectService.getDepartment();
    this.ticketForm = this.formBuilder.group({
      ticketid: ['', Validators.required],
      department: ['', Validators.required],
      category: ['', Validators.required],
      subCategory: ['', Validators.required],
      customer: ['', Validators.required],
      issueTime: ['', Validators.required],
      subject: ['', Validators.required],
      issueDescription: ['', Validators.required],
      emailId: ['', Validators.required],
      escEmail: ['', Validators.required],
      teamLink: ['', Validators.required],
      status: ['open'],
      lastModifiedDate: [''],
      ticketage: [''],
    });
    
  }
 public OnFormSubmit(form: NgForm):void {
    this.ticketService.addTicket(form).subscribe({
      next: (_res) => {
        this.toastrService.showSuccess('Ticket Added Successfully','Message');
        this.router.navigate(['/landingpage']);
      },
      error: () => {
        this.toastrService.showError('Something went wrong','Error')
      }
    })
  }
  
  public onSelect(departmentid:any) {
    this.category = this.selectService.getCategory().filter((item) => item.departmentid == departmentid.value);
  }
  public onSelectSub(categoryid:any){
    this.subcategory = this.selectService.getSubCategory().filter((item)=> item.categoryid == categoryid.value);
  }
}
