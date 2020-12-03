using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back_meet_room.Model
{
    public class Agendamento
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
