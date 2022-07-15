import { Component, OnInit } from '@angular/core';

import { Category } from 'src/app/utils/category';
import { Department } from 'src/app/utils/department';
import { SelectService } from 'src/app/shared/service/select.service';

@Component({
  selector: 'app-select',
  templateUrl: './select.component.html',
  styleUrls: ['./select.component.css']
})
export class SelectComponent implements OnInit {

  selectedDepartment: Department = new Department(2, 'Brazil');
  departments: Department[];
  category: Category[];

  constructor(private selectService:SelectService) { }

  ngOnInit() {
    this.departments = this.selectService.getDepartment();
    this.onSelect(this.selectedDepartment.id);
  }

  public onSelect(departmentid:any) {
    this.category = this.selectService.getCategory().filter((item) => item.departmentid == departmentid.target.value);
  }

}
