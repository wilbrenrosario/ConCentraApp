import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ConsultarPlacasComponent } from './consultar-placas.component';

describe('ConsultarPlacasComponent', () => {
  let component: ConsultarPlacasComponent;
  let fixture: ComponentFixture<ConsultarPlacasComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ConsultarPlacasComponent]
    });
    fixture = TestBed.createComponent(ConsultarPlacasComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
