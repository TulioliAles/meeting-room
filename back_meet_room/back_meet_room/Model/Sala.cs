using System;

namespace back_meet_room.Model
{
    public class Sala
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
