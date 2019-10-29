import { TestBed } from '@angular/core/testing';

import { StarsShipService } from './starsShip.service';

describe('PeopleService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: StarsShipService = TestBed.get(StarsShipService);
    expect(service).toBeTruthy();
  });
});
