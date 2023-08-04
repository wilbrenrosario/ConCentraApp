import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RegistroPlacasComponent } from './registro-placas.component';

describe('RegistroPlacasComponent', () => {
  let component: RegistroPlacasComponent;
  let fixture: ComponentFixture<RegistroPlacasComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [RegistroPlacasComponent]
    });
    fixture = TestBed.createComponent(RegistroPlacasComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
