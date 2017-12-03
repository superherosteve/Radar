import { TestBed, inject } from '@angular/core/testing';

import { SecureFileService } from './secure-file.service';

describe('SecureFileService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [SecureFileService]
    });
  });

  it('should be created', inject([SecureFileService], (service: SecureFileService) => {
    expect(service).toBeTruthy();
  }));
});
