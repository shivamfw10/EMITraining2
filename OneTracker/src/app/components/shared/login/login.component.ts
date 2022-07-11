import { Component, OnInit } from '@angular/core';

import { AuthenticateService } from 'src/app/shared/service/authenticate.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(private authenticate:AuthenticateService) { }
  
  ngOnInit(): void {
  }
  onSubmit(form:any){
    this.authenticate.authenticateUser(form.value);
  }
}
