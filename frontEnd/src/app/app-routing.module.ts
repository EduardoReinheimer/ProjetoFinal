import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AgendamentoComponent } from './agendamento/agendamento.component';
import { CidadeComponent } from './cidade/cidade.component';
import { EstadoComponent } from './estado/estado.component';
import { LogradouroComponent } from './logradouro/logradouro.component';
import { PedidoComponent } from './pedido/pedido.component';
import { PessoaFisicaComponent } from './pessoa-fisica/pessoa-fisica.component';
import { PessoaJuridicaComponent } from './pessoa-juridica/pessoa-juridica.component';
import { ProdutoComponent } from './produto/produto.component';
import { VeiculoComponent } from './veiculo/veiculo.component';

const routes: Routes = [
  { path: '', pathMatch: 'full', redirectTo: '/welcome' },
  {path: 'estado', component: EstadoComponent},
  {path: 'cidade', component: CidadeComponent},
  {path: 'veiculo', component: VeiculoComponent},
  {path: 'logradouro', component: LogradouroComponent},
  {path: 'pessoaFisica', component: PessoaFisicaComponent},
  {path: 'pessoaJuridica', component: PessoaJuridicaComponent},
  {path: 'produto', component: ProdutoComponent},
  {path: 'pedido', component: PedidoComponent},
  {path: 'agendamento', component: AgendamentoComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
