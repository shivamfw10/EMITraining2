import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RequestedbookComponent } from './requestedbook.component';

describe('RequestedbookComponent', () => {
  let component: RequestedbookComponent;
  let fixture: ComponentFixture<RequestedbookComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RequestedbookComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RequestedbookComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
