import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SkillAddComponent } from './skill-add.component';

describe('SkillAddComponent', () => {
  let component: SkillAddComponent;
  let fixture: ComponentFixture<SkillAddComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [SkillAddComponent]
    });
    fixture = TestBed.createComponent(SkillAddComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
