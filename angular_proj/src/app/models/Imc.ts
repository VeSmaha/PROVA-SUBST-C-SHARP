import { Usuario } from "./Usuario";

export interface Imc{
    imcID?:number;
    altura:number;
    peso:number;
    usuarioId:number;
    usuario?:Usuario;
    imcTotal?:number;
    classificacao?:number;
    criadoEm?:string;

}