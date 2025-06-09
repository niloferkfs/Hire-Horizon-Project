import { NgModule, Optional, SkipSelf } from '@angular/core';

// CoreModule might have services, guards, interceptors
import { AuthServiceService } from '../auth/services/auth-service.service'; // Adjust path
import { AuthInterceptor } from './interceptor/auth.interceptor'; // Adjust path
import { HTTP_INTERCEPTORS } from '@angular/common/http';

@NgModule({
  providers: [
    AuthServiceService, // Example: authentication service
    {
      provide: HTTP_INTERCEPTORS,
      useClass: AuthInterceptor, // Example: add interceptors
      multi: true
    }
  ]
})
export class CoreModule {
  constructor(@Optional() @SkipSelf() parentModule: CoreModule) {
    if (parentModule) {
      throw new Error('CoreModule is already loaded. Import it in AppModule only.');
    }
  }
}
