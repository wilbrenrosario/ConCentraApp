import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { RegistroPlacasComponent } from './registro-placas/registro-placas.component';
import { ConsultarPlacasComponent } from './consultar-placas/consultar-placas.component';
import { ConsultarPlacasGeneradasComponent } from './consultar-placas-generadas/consultar-placas-generadas.component';
import { LoginComponent } from './login/login.component';

const routes: Routes = [
  { path: "", redirectTo: "login", pathMatch: "full" },
  { path: "home", component: HomeComponent },
  { path: "registro-placas", component: RegistroPlacasComponent },
  { path: "consultar-placas", component: ConsultarPlacasComponent },
  { path: "consultar-placas-generadas", component: ConsultarPlacasGeneradasComponent },
  { path: "login", component: LoginComponent }
]

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
