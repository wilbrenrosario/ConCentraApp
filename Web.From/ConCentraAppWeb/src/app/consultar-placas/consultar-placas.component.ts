import { Component, OnInit } from '@angular/core';
import { Placas } from '../models/Placas';
import { DbContextService } from '../services/db-context.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-consultar-placas',
  templateUrl: './consultar-placas.component.html'
})
export class ConsultarPlacasComponent implements OnInit  {
  public tittle: string = "ConCentraAppWeb";

  public placas: Placas[] = [];

  constructor(private backend: DbContextService) { }

  ngOnInit(): void {
    this.obtenerProductos();
  }

  obtenerProductos(){
    this.backend.getPlacas().subscribe((pla: any) => {
      this.placas = pla;
    });
  }

  crearPlaca(id: string, pl: Placas){


    Swal.fire({
      title: 'Quieres confirmar esta solicitud de placa?',
      showDenyButton: false,
      showCancelButton: true,
      confirmButtonText: 'Si!',
    }).then((result) => {
      /* Read more about isConfirmed, isDenied below */
      if (result.isConfirmed) {
        this.backend.putPlacas(id, pl).subscribe((pro: any) => {
          this.obtenerProductos();
          Swal.fire(
            'Placa Generada!',
            'Puede visualizar las placas autorizadas y generadas en "Placas Generadas"!',
            'success',
          )
         });
      } else if (result.isDenied) {
      }
    })
  }
}
