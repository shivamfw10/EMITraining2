import { AuthenticateService } from 'src/app/core/services/authenticate.service';
import { Component } from '@angular/core';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent{

  constructor(private authenticate:AuthenticateService) { }

  public onSubmit(form:any):void{
    this.authenticate.authenticateUser(form.value);
  }
}
