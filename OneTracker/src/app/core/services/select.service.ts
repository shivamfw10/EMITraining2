import { Category } from '../utils/category';
import { Department } from '../utils/department';
import { Injectable } from '@angular/core';
import { Subcategory } from '../utils/subcategory';

@Injectable({
  providedIn: 'root'
})
export class SelectService {
  public getDepartment() {
    return [
     new Department(1, 'Technology' ),
     new Department(2, 'Research' ),
    ];
  }
  
  public getCategory() {
   return [
     new Category(1, 1, 'Technology'),
     new Category(2, 1, 'Cyber Security'),
     new Category(3, 1, 'Finance'),
     new Category(4, 1, 'Permissions'),
     new Category(5, 1, 'Staff Information'),
     new Category(6, 2, 'MS Office'),
     new Category(7, 2, 'Salesforce' )
    ];
  }
  public getSubCategory(){
    return[
      new Subcategory(1,1,1,'Hardware'),
      new Subcategory(2,1,1,'Data Extraction')
    ]
  }

  
}
