import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ImcListarComponent } from './pages/imc/imc-listar/imc-listar.component';
import { ImcCadastrarComponent } from './pages/imc/imc-cadastrar/imc-cadastrar.component';
import { UsuarioCadastrarComponent } from './pages/usuario/usuario-cadastrar/usuario-cadastrar.component';

@NgModule({
  declarations: [
    AppComponent,
    ImcListarComponent,
    ImcCadastrarComponent,
    UsuarioCadastrarComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
