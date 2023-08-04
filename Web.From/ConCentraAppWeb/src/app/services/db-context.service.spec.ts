import { TestBed } from '@angular/core/testing';

import { DbContextService } from './db-context.service';

describe('DbContextService', () => {
  let service: DbContextService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(DbContextService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
