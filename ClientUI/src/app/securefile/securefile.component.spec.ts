import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SecurefileComponent } from './securefile.component';

describe('SecurefileComponent', () => {
  let component: SecurefileComponent;
  let fixture: ComponentFixture<SecurefileComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SecurefileComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SecurefileComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});
