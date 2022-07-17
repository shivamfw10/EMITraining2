import { Component, Inject, OnInit } from '@angular/core';
import { FormGroup, NgForm, FormBuilder, Validators } from '@angular/forms';

import { MatDialog, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { NotificationService } from 'src/app/shared/service/notification.service';
import { UserService } from 'src/app/shared/service/user.service';

@Component({
  selector: 'app-updateuser',
  templateUrl: './updateuser.component.html',
  styleUrls: ['./updateuser.component.css']
})
export class UpdateuserComponent implements OnInit {
  userForm:FormGroup;
  constructor(public matDialog:MatDialog,
              private userService:UserService,
              private formBuilder:FormBuilder,
              @Inject(MAT_DIALOG_DATA) public editUser: any, 
              private toastrService:NotificationService,
              private dialogref: MatDialogRef<UpdateuserComponent>) { }

  ngOnInit(): void {
    this.userForm = this.formBuilder.group({
      firstName: ['', Validators.required],
      lastName: ['', Validators.required],
      email: ['', Validators.required],
      password: ['', Validators.required],
      status:['',Validators.required]
    })

    if (this.editUser) {
      this.userForm.controls['firstName'].setValue(this.editUser.firstName);
      this.userForm.controls['lastName'].setValue(this.editUser.lastName);
      this.userForm.controls['email'].setValue(this.editUser.email);
      this.userForm.controls['password'].setValue(this.editUser.password);
      this.userForm.controls['status'].setValue(this.editUser.status);
    }       
  }

  public onFormSubmit(form:NgForm){
    this.userService.EditUser(form,this.editUser.id).subscribe({
      next: (res) => {
        this.toastrService.showSuccess('Detail Updated Successfully','Message');
        this.userForm.reset();
        this.dialogref.close('update');
      },
      error: () => {
        this.toastrService.showError('Something went wrong','Error')
        
      }
    })
  }

  public matClose(){
    this.matDialog.closeAll();
  }
}
