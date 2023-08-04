import { Component, OnInit } from '@angular/core';
import { DbContextService } from '../services/db-context.service';
import { Placas } from '../models/Placas';
import { FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-consultar-placas-generadas',
  templateUrl: './consultar-placas-generadas.component.html'
})
export class ConsultarPlacasGeneradasComponent implements OnInit{
  public tittle: string = "ConCentraAppWeb";

  public placas: Placas[] = [];

  form!: FormGroup;

  constructor(private backend: DbContextService, private formBuilder:FormBuilder) { }

  ngOnInit(): void {
    this.obtenerProductos();
    this.form = this.formBuilder.group({
      Cedula: ''
    });
  }

  obtenerProductos(){
    this.backend.getPlacasGeneradas().subscribe((pla: any) => {
      this.placas = pla;
      console.log(this.placas);
    });
  }

  buscar(){
    this.backend.getPlacaByDni(this.form.value.Cedula).subscribe((pla: any) => {
      this.placas = pla;
    });
  }
}
