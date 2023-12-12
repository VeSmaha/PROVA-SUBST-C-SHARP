import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Usuario } from 'src/app/models/Usuario';

@Component({
  selector: 'app-usuario-cadastrar',
  templateUrl: './usuario-cadastrar.component.html',
  styleUrls: ['./usuario-cadastrar.component.css']
})
export class UsuarioCadastrarComponent implements OnInit {

  nome!:string;

  dataNasc!:string;

  constructor(private client:HttpClient, private router:Router) { }
  ngOnInit(): void {
    
  }
  cadastrar(): void {
    let usuario:Usuario={
      nome:this.nome,
      dataNasc:this.dataNasc
    }
    this.client.post<Usuario>("http://localhost:5066/api/usuario/cadastrar", usuario).subscribe({
      next:(usuario)=>{
        console.table(usuario);
        this.router.navigate(["pages/imc/listar"]);
      }
    })
  }

}
