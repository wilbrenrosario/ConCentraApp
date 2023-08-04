import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html'
})
export class HomeComponent {
    public tittle: string = "ConCentraAppWeb";

    public registrar_placas_descripcion: string = "Creacion de solicitudes para placas de vehiculo.";

    public consultar_solicitudes_descripcion: string = "Gestion y autorizacion de creacion de placas.";
}
