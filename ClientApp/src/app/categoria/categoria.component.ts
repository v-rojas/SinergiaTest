import { Component } from '@angular/core';
import { FormBuilder, FormGroup, FormControl } from '@angular/forms';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-categoria-component',
  templateUrl: './categoria.component.html'
})
export class CategoriaComponent {

  categoriaForm = new FormGroup(
    {
      nombre: new FormControl(''),
      descripcion: new FormControl('')
    });

  constructor(
    private http: HttpClient
  ) {
  }

  get form() {
    return this.categoriaForm.value;    
  }

  crearCategoria() {
    this.http.post('Categoria/AddCategoria', this.categoriaForm.value).subscribe((data: any) => {
      console.log(data);
    });    
  }

  obtenerCategorias() {
    this.http.get('Categoria/GetCategoria', this.categoriaForm.value).subscribe((data: any) => {
      console.log(data);
    });    
  }

}
