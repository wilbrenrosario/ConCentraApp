import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Placas } from '../models/Placas';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DbContextService {

  private Url: string = "http://localhost:5209/api/";
  Token: string = "";
  reload: number = 1;

  constructor(private http: HttpClient) {
    sessionStorage.getItem('token')
  }

  // Http Options
  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json',
      'Authorization': 'Bearer ' + sessionStorage.getItem('token')
    }),
  };

  getPlacas() : Observable<Placas[]> {
    console.log(this.Token);
    return this.http.get<Placas[]>(this.Url + "Placas", this.httpOptions);
  }

  getPlacasGeneradas() : Observable<Placas[]> {
    return this.http.get<Placas[]>(this.Url + "Placas/GetAllNotActive/false", this.httpOptions);
  }

  postPlaca(placa: Placas) : Observable<Placas> {
    return this.http.post<Placas>(this.Url + "Placas", JSON.stringify(placa), this.httpOptions);
  }

  getPlacaByDni(dni: string) : Observable<Placas> {
    return this.http.get<Placas>( this.Url + "Placas/" + dni,  this.httpOptions);
  }

  putPlacas(id: string, placa: Placas) : Observable<void> {
    return this.http.put<void>(this.Url + "Placas/" + id, placa,  this.httpOptions);
  }


  //Login
  postLogin(datos: void) : Observable<void> {
    return this.http.post<void>(this.Url + "Usuarios", JSON.stringify(datos), this.httpOptions);
  }

}
