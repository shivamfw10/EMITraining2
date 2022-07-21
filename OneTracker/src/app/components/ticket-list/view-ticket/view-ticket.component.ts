
import { Component, Inject} from '@angular/core';
import { MatDialog, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';

@Component({
  selector: 'app-view-ticket',
  templateUrl: './view-ticket.component.html',
  styleUrls: ['./view-ticket.component.css']
})
export class ViewTicketComponent{
  constructor(
    public matDialog:MatDialog,
  @Inject(MAT_DIALOG_DATA) public ticket: any, 
  private dialogref: MatDialogRef<ViewTicketComponent>) { }

}
