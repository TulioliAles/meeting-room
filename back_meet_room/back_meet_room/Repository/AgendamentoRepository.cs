using back_meet_room.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back_meet_room.Repository
{
    public class AgendamentoRepository
    {
        private AgendamentoContext Context { get; set; }

        public AgendamentoRepository(AgendamentoContext context)
        {
            this.Context = context;
        }

        public async Task<IList<Agendamento>> GetAllAsync()
            => await this.Context.Agendamentos.Include(x => x.DataReserva).ToListAsync();

        public async Task<Agendamento> GetAgendaByIdAsync(Guid id)
            => await this.Context.Agendamentos.Include(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(Agendamento agendamento)
        {
            await this.Context.Agendamentos.AddAsync(agendamento);
            await this.Context.SaveChangesAsync();
        }

        public async Task<Agendamento> GetAgendamentoAsync(Guid id)
          => await this.Context.Agendamentos
                            .Include(x => x.Id)
                            .Where(x => x.Id == id)
                            .FirstOrDefaultAsync();

        public async Task RemoveAsync(Agendamento agendamento)
        {
            this.Context.Agendamentos.Remove(agendamento);
            await this.Context.SaveChangesAsync();
        }
    }
}
