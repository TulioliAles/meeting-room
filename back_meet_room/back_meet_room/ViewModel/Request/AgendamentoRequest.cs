using System;
using System.ComponentModel.DataAnnotations;

namespace back_meet_room.ViewModel.Request
{
    public class AgendamentoRequest
    {
        [Required]
        public DateTime DataReserva { get; set; }

        [Required]
        public DateTime HoraInicio { get; set; }

        [Required]
        public DateTime HoraFim { get; set; }

        [Required]
        public Boolean Computador { get; set; }

        [Required]
        public Boolean Projetor { get; set; }

        [Required]
        public Boolean Video { get; set; }
    }
}
