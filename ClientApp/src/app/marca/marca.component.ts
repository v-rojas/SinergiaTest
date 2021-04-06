import { Component } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-marca-component',
  templateUrl: './marca.component.html'
})
export class MarcaComponent {

  marcaForm = new FormGroup(
    {
      nombre: new FormControl(''),
      descripcion: new FormControl('')
    });

  constructor(
    private http: HttpClient
  ) {
  }

  get form() {
    return this.marcaForm.value;
  }

  crearMarca() {
    this.http.post('Marca/AddMarca', this.marcaForm.value).subscribe((data: any) => {
      console.log(data);
    });
  }

  obtenerMarca() {
    this.http.get('Marca/GetMarca', this.marcaForm.value).subscribe((data: any) => {
      console.log(data);
    });
  }
}
