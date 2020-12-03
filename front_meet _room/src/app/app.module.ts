import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { DataTablesModule } from 'angular-datatables';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';


import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ApiService } from './service/api.service';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { SalasCreateComponent } from './salas/salas-create/salas-create.component';
import { SalasEditComponent } from './salas/salas-edit/salas-edit.component';
import { SalasListComponent } from './salas/salas-list/salas-list.component';
import { AgendamentoComponent } from './agendamento/agendamento/agendamento.component';
import { TextMaskModule } from 'angular2-text-mask';
import { DatePipe } from '@angular/common';
import { NgxSpinnerModule } from "ngx-spinner";

@NgModule({
  declarations: [
    AppComponent,
    SalasCreateComponent,
    SalasEditComponent,
    SalasListComponent,
    AgendamentoComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    DataTablesModule,
    FormsModule,
    ReactiveFormsModule,
    FontAwesomeModule,
    TextMaskModule,
    NgxSpinnerModule
  ],
  providers: [
    ApiService,
    DatePipe
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
