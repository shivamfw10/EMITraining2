import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, NgForm, Validators } from '@angular/forms';

import { MatDialog } from '@angular/material/dialog';
import { NotificationService } from 'src/app/core/services/notification.service';
import { UserService } from 'src/app/core/services/user.service';

@Component({
  selector: 'app-adduser',
  templateUrl: './adduser.component.html',
  styleUrls: ['./adduser.component.css']
})
export class AdduserComponent implements OnInit {
  userForm!:FormGroup;
  date= new Date();
  constructor(public matDialog:MatDialog,
              private formBuilder:FormBuilder,
              private userService:UserService,
              private toastrService:NotificationService) { }
  ngOnInit(): void {
    this.userForm = this.formBuilder.group({
      firstName: ['', Validators.required],
      lastName: ['', Validators.required],
      email: ['', Validators.required],
      role: ['user', Validators.required],
      password: ['', Validators.required],
      status:[true],
      date: [this.date, Validators.required]
    });
  }
  public matClose():void{
    this.matDialog.closeAll();
  }
  public onFormSubmit(form:NgForm):void{
    this.userService.addUser(form).subscribe({
      next: (_res) => {
        this.toastrService.showSuccess('User Registered Successfully','Message');
        this.matDialog.closeAll();
      },
      error: () => {
        this.toastrService.showError('Something went wrong','Error');
      }
    })
  }
}
