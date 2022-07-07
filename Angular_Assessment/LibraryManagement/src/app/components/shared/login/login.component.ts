import { Component, OnInit } from '@angular/core';
import { FormGroup, NgForm } from '@angular/forms';

import { AuthenticateService } from 'src/app/shared_module/service/authenticate.service';
import { NotificationsService } from 'src/app/shared_module/service/notifications.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  hide = true;
  loginForm:FormGroup;
  constructor(private service:AuthenticateService,private toastr:NotificationsService) { }

  ngOnInit(): void {
  }

  public onSubmit(form:NgForm)
  {
    this.service.authenticateEmployee(form.value);
  }
}
