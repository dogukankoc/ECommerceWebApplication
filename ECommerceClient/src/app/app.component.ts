import { Component } from '@angular/core';
declare var $: any
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'ECommerceClient';
  
  }

  $.get("https://localhost:7221/api/products",data =>{console.log(data) //Gelecek Datayı Consola yazdırıyoruz.
  }) ;
  