import { Category } from 'src/app/utils/category';
import { Department } from 'src/app/utils/department';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class SelectService {

  constructor() { }
  getDepartment() {
    return [
     new Department(1, 'USA' ),
     new Department(2, 'Brazil' ),
    ];
  }
  
  getCategory() {
   return [
     new Category(1, 1, 'Arizona' ),
     new Category(2, 1, 'Alaska' ),
     new Category(3, 1, 'Florida'),
     new Category(4, 1, 'Hawaii'),
     new Category(5, 2, 'Sao Paulo' ),
     new Category(6, 2, 'Rio de Janeiro'),
     new Category(7, 2, 'Minas Gerais' )
    ];
  }
}
