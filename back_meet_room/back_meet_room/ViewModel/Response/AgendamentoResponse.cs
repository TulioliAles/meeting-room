using System;

namespace back_meet_room.ViewModel.Response
{
    public class AgendamentoResponse
    {
        public Guid Id { get; set; }

        public DateTime DataReserva { get; set; }

        public DateTime HoraInicio { get; set; }

        public DateTime HoraFim { get; set; }

        public Boolean Computador { get; set; }

        public Boolean Projetor { get; set; }

        public Boolean Video { get; set; }
    }
}
