import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit {

  productoForm = new FormGroup(
    {
      nombre: new FormControl(''),
      descripcion: new FormControl(''),
      categoria: new FormControl(''),
      proveedor: new FormControl(''),
      marca: new FormControl(''),
      medidas: new FormControl(''),
      cantidad: new FormControl(''),
      precio_unitario: new FormControl('')
    });
  
  categorias: any;
  marcas: any;
  proveedores: any;

  constructor(
    private http: HttpClient
  ) {

  }

  async ngOnInit() {
    this.categorias = await this.http.get('Categoria/GetCategoria').toPromise();
    this.marcas = await this.http.get('Marca/GetMarca').toPromise();
    this.proveedores = await this.http.get('Proveedor/GetProveedor').toPromise();
    console.log(this.categorias);
  }

  crearProductos() {
    this.http.post('Productos/AddProductos', this.productoForm.value).subscribe((data: any) => {
      console.log(data);
    });    
  }
}
