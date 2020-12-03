using back_meet_room.Model;
using back_meet_room.ViewModel.Request;

namespace back_meet_room.ViewModel.Profile
{
    public class AgendamentoProfile : AutoMapper.Profile
    {
        public AgendamentoProfile()
        {
            CreateMap<SalaRequest, Sala>();
            CreateMap<AgendamentoRequest, Agendamento>();
        }
    }
}
