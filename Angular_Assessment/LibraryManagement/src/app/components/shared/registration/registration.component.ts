import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

import { NotificationsService } from 'src/app/shared_module/service/notifications.service';
import { Router } from '@angular/router';
import { UserService } from 'src/app/shared_module/service/user.service';

@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.css']
})
export class RegistrationComponent implements OnInit {
  hide=true;
  registrationForm:FormGroup;
  constructor(private userService:UserService,
    private formBuiler:FormBuilder,
    private router:Router,
    private toastr:NotificationsService) { }

  ngOnInit(): void {
    this.registrationForm=this.formBuiler.group({
      firstName:['',Validators.required],
      lastName:['',Validators.required],
      email:['',Validators.required],
      password:['',Validators.required],
      data:[''],
      role:['user',Validators.required]
    })
  }

  public SaveUser(registraform:any){
    this.userService.addUser(registraform).subscribe(response=>{
      const id = response['id'];
      this.toastr.showSuccess('Congratulations','Registered Successfully');
      this.router.navigate(['']);
    },error=>{
      this.toastr.showError('Warning','Try again');
    })
  }

}
