import { CanActivateFn,Router } from '@angular/router';

import { inject } from '@angular/core';
import { ActivatedRouteSnapshot,RouterStateSnapshot } from '@angular/router';
import { AuthServiceService } from 'src/app/auth/services/auth-service.service';


export const authGuard: CanActivateFn = (
  route: ActivatedRouteSnapshot,
  state: RouterStateSnapshot
) => {
  const authService = inject(AuthServiceService);
  const router = inject(Router);

  if (authService.isAuthenticated()) {
    return true;
  } else {
    // Redirect to login or return a UrlTree
    return router.parseUrl('/login');
  }
};
