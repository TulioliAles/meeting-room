import { Time } from '@angular/common';

export class Agendamento {
    DataReserva: Date;
    HoraInicio: Time;
    HoraFim: Time;
    Computador: boolean;
    Projetor: boolean;
    Video: boolean;
}