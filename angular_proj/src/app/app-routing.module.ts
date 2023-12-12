import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { UsuarioCadastrarComponent } from './pages/usuario/usuario-cadastrar/usuario-cadastrar.component';
import { ImcCadastrarComponent } from './pages/imc/imc-cadastrar/imc-cadastrar.component';
import { ImcListarComponent } from './pages/imc/imc-listar/imc-listar.component';

const routes: Routes = [
  {
    path: "pages/usuario/cadastrar",
    component: UsuarioCadastrarComponent
  },
  {
    path: "pages/imc/cadastrar",
    component: ImcCadastrarComponent
  },
  {
    path: "pages/imc/listar",
    component: ImcListarComponent
  },
  {
    path: "",
    component: ImcListarComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
