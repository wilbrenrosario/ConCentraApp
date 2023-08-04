import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HomeComponent } from './home/home.component';

import {MatCardModule} from '@angular/material/card';
import { RegistroPlacasComponent } from './registro-placas/registro-placas.component';

import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DbContextService } from './services/db-context.service';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    RegistroPlacasComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatCardModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [DbContextService],
  bootstrap: [AppComponent]
})
export class AppModule { }
