import { Component, OnInit } from '@angular/core';
import { Placas } from '../models/Placas';
import { ActivatedRoute, Router } from '@angular/router';
import { DbContextService } from '../services/db-context.service';
import { FormBuilder, FormGroup } from '@angular/forms';
import Swal from 'sweetalert2';

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
      TipoPersonas: '-1',
      TipoAutomovil: '-1',
      ValorTotalPlaca: 0
    });

  }

  saveForm(){
    console.log(this.form.value.FechaNacimiento);
    if(this.form.value.Cedula == ""){
      Swal.fire(
        '',
        'Favor ingresar su cedula!',
        'info',
      )
      return;
    }
    if(this.form.value.TipoAutomovil == "-1"){
      Swal.fire(
        '',
        'Favor seleccionar un tipo de automovil!',
        'info',
      )
      return;
    }

    if(this.form.value.TipoPersonas == "-1"){
      Swal.fire(
        '',
        'Favor seleccionar un tipo de persona!',
        'info',
      )
      return;
    }

    if(this.form.value.FechaNacimiento == ""){
      Swal.fire(
        '',
        'Favor ingresar fecha de nacimiento!',
        'info',
      )
      return;
    }

    if(this.form.value.ValorTotalPlaca <= 0){
      Swal.fire(
        '',
        'Favor ingresar valor de la placa!',
        'info',
      )
      return;
    }

   this.backend.postPlaca(this.form.value).subscribe((pro: any) => {
     console.log("DONE");
     this.showModel();
    });
  }

  showModel(){
    Swal.fire(
      'Registrado!',
      'Su solicitud para la creacion de placa fue exitosa!',
      'success',
    ).then((result) => {
      if(result.isConfirmed){
        this.goToHome();
      }else if(result.isDismissed){
        this.goToHome();
      }
    })
  }

  goToHome(){
    this.rou.navigate(['/']);
  }
}
