import { TestBed } from '@angular/core/testing';
import { CanActivateFn } from '@angular/router';

import { esLoginGuard } from './es-login.guard';

describe('esLoginGuard', () => {
  const executeGuard: CanActivateFn = (...guardParameters) => 
      TestBed.runInInjectionContext(() => esLoginGuard(...guardParameters));

  beforeEach(() => {
    TestBed.configureTestingModule({});
  });

  it('should be created', () => {
    expect(executeGuard).toBeTruthy();
  });
});
