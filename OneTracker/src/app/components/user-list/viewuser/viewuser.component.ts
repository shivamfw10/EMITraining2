import { Component, Inject} from '@angular/core';

import { MatDialog, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';


@Component({
  selector: 'app-viewuser',
  templateUrl: './viewuser.component.html',
  styleUrls: ['./viewuser.component.css']
})
export class ViewuserComponent{
  constructor(public matDialog:MatDialog,
  @Inject(MAT_DIALOG_DATA) public userData: any, 
  private dialogref: MatDialogRef<ViewuserComponent>) { }
  public matClose():void{
    this.matDialog.closeAll();
  }
}
