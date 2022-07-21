import { CommonModule } from '@angular/common';
import {MatBadgeModule} from '@angular/material/badge';
import {MatButtonModule} from '@angular/material/button';
import {MatCardModule} from '@angular/material/card';
import {MatDatepickerModule} from '@angular/material/datepicker';
import {MatDialogModule} from '@angular/material/dialog';
import {MatFormFieldModule} from '@angular/material/form-field';
import {MatIconModule} from '@angular/material/icon';
import {MatInputModule} from '@angular/material/input';
import {MatPaginatorModule} from '@angular/material/paginator';
import {MatSelectModule} from '@angular/material/select';
import {MatSidenavModule} from '@angular/material/sidenav';
import {MatTableModule} from '@angular/material/table';
import {MatToolbarModule} from '@angular/material/toolbar';
import { NgModule } from '@angular/core';
const UX_Module =[MatToolbarModule,
                  MatButtonModule,
                  MatCardModule,
                  MatDatepickerModule,
                  MatFormFieldModule,
                  MatIconModule,
                  MatInputModule,
                  MatPaginatorModule,
                  MatSelectModule,
                  MatTableModule,
                  MatBadgeModule,
                  MatSidenavModule,
                  MatDialogModule]
@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    UX_Module
  ],
  exports:[
    UX_Module
  ]
})
export class MatMaduleModule { }
