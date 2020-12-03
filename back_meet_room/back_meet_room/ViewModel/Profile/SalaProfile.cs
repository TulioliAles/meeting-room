using back_meet_room.Model;
using back_meet_room.ViewModel.Request;
using back_meet_room.ViewModel.Response;

namespace back_meet_room.ViewModel.Profile
{
    public class SalaProfile : AutoMapper.Profile
    {
        public SalaProfile()
        {
            CreateMap<AgendamentoRequest, Agendamento>();
            CreateMap<Sala, SalaResponse>();
        }
    }
}
