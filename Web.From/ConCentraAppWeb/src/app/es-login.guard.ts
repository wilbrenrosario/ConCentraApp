import { CanActivateFn } from '@angular/router';

export const esLoginGuard: CanActivateFn = (route, state) => {
  return true;
};
