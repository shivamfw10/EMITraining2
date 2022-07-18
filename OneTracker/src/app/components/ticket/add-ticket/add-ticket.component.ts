import { Component, OnChanges, OnInit, SimpleChanges } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, NgForm, Validators } from '@angular/forms';

import { Category } from 'src/app/utils/category';
import { Department } from 'src/app/utils/department';
import { Router } from '@angular/router';
import { SelectService } from 'src/app/shared/service/select.service';
import { Subcategory } from 'src/app/utils/subcategory';
import { TicketService } from 'src/app/shared/service/ticket.service';

@Component({
  selector: 'app-add-ticket',
  templateUrl: './add-ticket.component.html',
  styleUrls: ['./add-ticket.component.css'],
})
export class AddTicketComponent implements OnInit, OnChanges {
  ticketForm: FormGroup;
  departments: Department[];
  category: Category[];
  subcategory:Subcategory[];
  // disableSelect = new FormControl(false);
  constructor(
    private ticketService: TicketService,
    private formBuilder: FormBuilder,
    private router: Router,
    private selectService:SelectService
  ) {}

  ngOnInit(): void {
    this.departments = this.selectService.getDepartment();
    this.category = this.selectService.getCategory();
    this.subcategory = this.selectService.getSubCategory();
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
  ngOnChanges(): void {
    //this.category = this.selectService.getCategory();
  }
  OnFormSubmit(form: NgForm) {
    this.ticketService.addTicket(form).subscribe(
      (response) => {
        const id = response['id'];
        this.router.navigate(['/landingpage']);
      },
      (error) => {
        console.log(error);
      }
    );
  }
  public onSelect(departmentid:any) {
    this.category = this.selectService.getCategory().filter((item) => item.departmentid == departmentid.target.value);
  }
  public onSelectSub(categoryid:any){
    this.subcategory = this.selectService.getSubCategory().filter((item)=> item.categoryid == categoryid.target.value);
  }
}
