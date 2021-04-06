import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { FormGroup, FormControl } from '@angular/forms';

@Component({
  selector: 'app-proveedor',
  templateUrl: './proveedor.component.html'
})
export class ProveedorComponent {
  
  proveedorForm = new FormGroup(
    {
      nombre: new FormControl(''),
      descripcion: new FormControl('')
    });

  constructor(
    private http: HttpClient
  ) {
  }

  get form() {
    return this.proveedorForm.value;
  }

  crearProveedor() {
    this.http.post('Proveedor/AddProveedor', this.proveedorForm.value).subscribe((data: any) => {
      console.log(data);
    });
  }

  obtenerProveedor() {
    this.http.get('Proveedor/GetProveedor', this.proveedorForm.value).subscribe((data: any) => {
      console.log(data);
    });
  }

}

