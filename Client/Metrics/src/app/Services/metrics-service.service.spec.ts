import { TestBed } from '@angular/core/testing';

import { MetricsService } from './metrics-service.service';

describe('MetricsServiceService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: MetricsService = TestBed.get(MetricsService);
    expect(service).toBeTruthy();
  });
});
