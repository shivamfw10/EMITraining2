import { Component, OnInit } from '@angular/core';

import { Category } from 'src/app/utils/category';
import { Department } from 'src/app/utils/department';
import { SelectService } from 'src/app/shared/service/select.service';
import { Subcategory } from '../utils/subcategory';

@Component({
  selector: 'app-select',
  templateUrl: './select.component.html',
  styleUrls: ['./select.component.css']
})
export class SelectComponent implements OnInit {
  departments: Department[];
  category: Category[];
  subcategory:Subcategory[];
  constructor(private selectService:SelectService) { }
  ngOnInit() {
    this.departments = this.selectService.getDepartment();
    //this.category=this.selectService.getCategory();
    
  }
  public onSelect(departmentid:any) {
    this.category = this.selectService.getCategory().filter((item) => item.departmentid == departmentid.target.value);
  }
  public onSelectSub(categoryid:any){
    // const savedFilters = this.selectService.getSubCategory();
    // const savedFiltersAsArray = savedFilters.filter((item:any) => item.key === 'filter');
    // this.subcategory = this.selectService.getSubCategory().filter
  }
}
