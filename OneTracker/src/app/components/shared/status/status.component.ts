import { Component, Input, OnChanges, OnInit, SimpleChanges } from '@angular/core';

@Component({
  selector: 'app-status',
  templateUrl: './status.component.html',
  styleUrls: ['./status.component.css']
})
export class StatusComponent implements OnInit,OnChanges {
  @Input() status :boolean;
  statusText:string;
  constructor() { }
  ngOnChanges(): void {
    if (this.status ===true) {
      this.statusText = 'Active';
    } else if (this.status ===false) {
      this.statusText = 'InActive';
    } 
    else{
      this.statusText = 'Unknown';
    }
  }
  ngOnInit(): void {
  }

}
