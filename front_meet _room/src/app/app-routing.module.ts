import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { SalasListComponent } from './salas/salas-list/salas-list.component';
import { SalasEditComponent } from './salas/salas-edit/salas-edit.component';
import { SalasCreateComponent } from './salas/salas-create/salas-create.component';
import { AgendamentoComponent } from './agendamento/agendamento/agendamento.component';


const routes: Routes = [

  { path: 'salas-create', component: SalasCreateComponent },
  { path: 'salas-edit/:id', component: SalasEditComponent },
  { path: 'salas-list', component: SalasListComponent },

  { path: 'agendamento', component: AgendamentoComponent },

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
