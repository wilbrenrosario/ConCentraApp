import { Component, OnInit } from '@angular/core';
import { DbContextService } from '../services/db-context.service';
import { Placas } from '../models/Placas';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html'
})
export class HomeComponent implements OnInit{

    constructor(private backend: DbContextService){}

    public tittle: string = "ConCentraAppWeb";

    public solicitudes: number = 0;

    public usuarios: number = 0;

    public registrar_placas_descripcion: string = "Creacion de solicitudes para placas de vehiculo.";

    public consultar_solicitudes_descripcion: string = "Gestion y autorizacion de creacion de placas.";

    public consultar_placas_descripcion: string = "Consulta de placas generadas y autorizadas.";

    ngOnInit(): void {
      this.backend.getPlacas().subscribe((pl: Placas[]) => {
          this.solicitudes = pl.length;
       });
    }
}
