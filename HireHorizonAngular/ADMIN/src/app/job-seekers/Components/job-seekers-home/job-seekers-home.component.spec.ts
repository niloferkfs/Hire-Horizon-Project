import { ComponentFixture, TestBed } from '@angular/core/testing';

import { JobSeekersHomeComponent } from './job-seekers-home.component';

describe('JobSeekersHomeComponent', () => {
  let component: JobSeekersHomeComponent;
  let fixture: ComponentFixture<JobSeekersHomeComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [JobSeekersHomeComponent]
    });
    fixture = TestBed.createComponent(JobSeekersHomeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
