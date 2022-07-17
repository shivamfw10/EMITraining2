import { Component, Inject, OnInit } from '@angular/core';

import { MatDialog, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { NotificationService } from 'src/app/shared/service/notification.service';

@Component({
  selector: 'app-viewuser',
  templateUrl: './viewuser.component.html',
  styleUrls: ['./viewuser.component.css']
})
export class ViewuserComponent implements OnInit {
  constructor(public matDialog:MatDialog,
  @Inject(MAT_DIALOG_DATA) public userData: any, 
  private toastrService:NotificationService,
  private dialogref: MatDialogRef<ViewuserComponent>) { }

  ngOnInit(): void {
  
  }
  public matClose():void{
    this.matDialog.closeAll();
  }
}
