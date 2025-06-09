import { ComponentFixture, TestBed } from '@angular/core/testing';

import { JobProvidersHomeComponent } from './job-providers-home.component';

describe('JobProvidersHomeComponent', () => {
  let component: JobProvidersHomeComponent;
  let fixture: ComponentFixture<JobProvidersHomeComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [JobProvidersHomeComponent]
    });
    fixture = TestBed.createComponent(JobProvidersHomeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
