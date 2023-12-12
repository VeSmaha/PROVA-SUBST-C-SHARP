import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Imc } from 'src/app/models/Imc';

@Component({
  selector: 'app-imc-listar',
  templateUrl: './imc-listar.component.html',
  styleUrls: ['./imc-listar.component.css']
})
export class ImcListarComponent implements OnInit {

  Imcs : Imc[]=[];

  constructor(private client:HttpClient) { }

  ngOnInit(): void {
    this.client.get<Imc[]>("http://localhost:5066/api/imc/listar").subscribe({
      next:(imcs)=>{
        this.Imcs = imcs
      },error:(erro)=>{erro}
    })
  }

}
