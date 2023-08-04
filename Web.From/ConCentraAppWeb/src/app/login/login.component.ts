import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { DbContextService } from '../services/db-context.service';
import { ActivatedRoute, Router } from '@angular/router';
import Swal from 'sweetalert2';
import { HttpErrorResponse } from '@angular/common/http';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html'
})
export class LoginComponent implements OnInit {
  public tittle: string = "ConCentraAppWeb";
  constructor(private route: ActivatedRoute, private rou: Router, private backend: DbContextService, private formBuilder:FormBuilder) {  }

  form!: FormGroup;

  ngOnInit(): void {
    this.form = this.formBuilder.group({
      Usuario: '',
      Clave: '',
    });

  }

  saveForm(){
    if(this.form.value.Usuario == ""){
      Swal.fire(
        '',
        'Favor ingresar su Usuario!',
        'info',
      )
      return;
    }
    if(this.form.value.Clave == ""){
      Swal.fire(
        '',
        'Favor ingresar su Clave!',
        'info',
      )
      return;
    }

   this.backend.postLogin(this.form.value).subscribe((pro: any) => {
    if(pro.token != ""){
      sessionStorage.setItem('token', pro.token);
      sessionStorage.setItem('reload', "1");
      this.goToHome()
    }
    }, (err: HttpErrorResponse) => {
      if (err.status === 400) {
       console.log("403 status code caught");
       Swal.fire(
        '',
        'Usuario no existe!',
        'info',
      )
      return;
      }
    }

    );
  }

  goToHome(){
    this.rou.navigate(['/home']);
  }
}
