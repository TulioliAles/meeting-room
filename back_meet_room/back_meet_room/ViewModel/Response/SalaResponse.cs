using back_meet_room.Model;
using System;

namespace back_meet_room.ViewModel.Response
{
    public class SalaResponse
    {
        public Guid Id { get; set; }

        public String Nome { get; set; }

        public int Quantidade { get; set; }

        public Boolean Computador { get; set; }

        public Boolean Projetor { get; set; }

        public Boolean VideoConferencia { get; set; }

        public Agendamento Agendamento { get; set; }
    }
}
