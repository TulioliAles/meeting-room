using System;
using System.ComponentModel.DataAnnotations;

namespace back_meet_room.ViewModel.Request
{
    public class SalaRequest
    {
        [Required]
        public String Nome { get; set; }

        [Required]
        public int Quantidade { get; set; }

        [Required]
        public Boolean Computador { get; set; }

        [Required]
        public Boolean Projetor { get; set; }

        [Required]
        public Boolean VideoConferencia { get; set; }
    }
}
