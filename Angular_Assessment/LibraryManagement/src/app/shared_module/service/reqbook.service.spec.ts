import { TestBed } from '@angular/core/testing';

import { ReqbookService } from './reqbook.service';

describe('ReqbookService', () => {
  let service: ReqbookService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ReqbookService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
