import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Placas } from '../models/Placas';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DbContextService {

  private Url: string = "http://localhost:5209/api/";

  constructor(private http: HttpClient) {}

  // Http Options
  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json',
    }),
  };

  getPlacas() : Observable<Placas> {
    return this.http.get<Placas>(this.Url + "Placas", this.httpOptions);
  }

  postPlaca(placa: Placas) : Observable<Placas> {
    return this.http.post<Placas>(this.Url + "Placas", JSON.stringify(placa), this.httpOptions);
  }

  getPlacaByDni(dni: string) : Observable<Placas> {
    return this.http.get<Placas>( this.Url + "Placas/" + dni);
  }

  putPlacasB(id: string, placa: Placas) : Observable<void> {
    return this.http.put<void>(this.Url + "Placas/" + id, placa);
  }


}
