import { CommonModule } from '@angular/common';
import {MatBadgeModule} from '@angular/material/badge';
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';
import {MatCheckboxModule} from '@angular/material/checkbox';
import {MatFormFieldModule} from '@angular/material/form-field';
import { MatGridListModule } from '@angular/material/grid-list';
import { MatIconModule } from '@angular/material/icon';
import { MatInputModule } from '@angular/material/input';
import { MatMenuModule } from '@angular/material/menu';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatTableModule } from '@angular/material/table';
import { MatToolbarModule } from '@angular/material/toolbar';
import { NgModule } from '@angular/core';
const MatModule =[
  MatGridListModule,
  MatButtonModule,
  MatToolbarModule,
  MatIconModule,
  MatMenuModule,
  MatBadgeModule,
  MatFormFieldModule,
  MatInputModule,
  MatCardModule,
  MatInputModule,
  MatCheckboxModule,
  MatToolbarModule,
  MatPaginatorModule,
  MatTableModule
]
@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    MatModule
  ],
  exports:[
    MatModule
  ]
})
export class MaterialModule { }
