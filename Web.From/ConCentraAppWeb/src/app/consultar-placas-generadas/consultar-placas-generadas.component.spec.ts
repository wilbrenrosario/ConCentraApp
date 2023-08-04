import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ConsultarPlacasGeneradasComponent } from './consultar-placas-generadas.component';

describe('ConsultarPlacasGeneradasComponent', () => {
  let component: ConsultarPlacasGeneradasComponent;
  let fixture: ComponentFixture<ConsultarPlacasGeneradasComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ConsultarPlacasGeneradasComponent]
    });
    fixture = TestBed.createComponent(ConsultarPlacasGeneradasComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
