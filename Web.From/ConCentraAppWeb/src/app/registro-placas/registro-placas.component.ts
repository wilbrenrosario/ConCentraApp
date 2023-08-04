import { Component, OnInit } from '@angular/core';
import { Placas } from '../models/Placas';
import { ActivatedRoute, Router } from '@angular/router';
import { DbContextService } from '../services/db-context.service';
import { FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-registro-placas',
  templateUrl: './registro-placas.component.html'
})
export class RegistroPlacasComponent implements OnInit {
  public tittle: string = "ConCentraAppWeb";

  public placa: Placas = new Placas;
  constructor(private route: ActivatedRoute, private rou: Router, private backend: DbContextService, private formBuilder:FormBuilder) {  }

  form!: FormGroup;

  ngOnInit(): void {
    this.form = this.formBuilder.group({
      Nombres: '',
      Apellidos: '',
      Cedula: '',
      FechaNacimiento: '',
      TipoPlaca: '',
      TipoPersonas: '',
      TipoAutomovil: '',
      ValorTotal: 0
    });

  }

  saveForm(){
    //this.form.value['ID'] = this.id_producto;
    console.log("WORKING");
    console.log(this.form.value);
   this.backend.postPlaca(this.form.value).subscribe((pro: any) => {
     console.log("DONE");
    });
  }
}
