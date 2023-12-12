import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Imc } from 'src/app/models/Imc';
import { Usuario } from 'src/app/models/Usuario';

@Component({
  selector: 'app-imc-cadastrar',
  templateUrl: './imc-cadastrar.component.html',
  styleUrls: ['./imc-cadastrar.component.css']
})
export class ImcCadastrarComponent implements OnInit {

  constructor(private client:HttpClient, private router:Router) { }

  altura!:number;
  peso!:number;
  usuarioId!:number;


  usuarios:Usuario[]=[];

  ngOnInit(): void {
    this.client.get<Usuario[]>("http://localhost:5066/api/usuario/listar").subscribe({
      next:(usuarios)=>{
        this.usuarios = usuarios;
      },
      error:(erro)=>{erro}
    })
  }

  cadastrar(): void {
    let imc:Imc={
    altura:this.altura,
    peso:this.peso,
    usuarioId:this.usuarioId
    }
    this.client.post<Imc>("http://localhost:5066/api/imc/cadastrar", imc).subscribe({
      next:(imc)=>{
        console.table(imc);
        this.router.navigate(["pages/imc/listar"]);
      },error:(erro)=>{erro}
    })
  }
}
