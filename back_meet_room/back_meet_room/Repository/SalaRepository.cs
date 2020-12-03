using back_meet_room.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back_meet_room.Repository
{
    public class SalaRepository
    {
        private AgendamentoContext Context { get; set; }

        public SalaRepository(AgendamentoContext context)
        {
            this.Context = context;
        }

        public async Task<IList<Sala>> GetAllAsync()
            => await this.Context.Salas.Include(x => x.Nome).ToListAsync();

        public async Task<Sala> GetSalaByIdAsync(Guid id)
             => await this.Context.Salas.Include(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(Sala sala)
        {
            await this.Context.Salas.AddAsync(sala);
            await this.Context.SaveChangesAsync();
        }

        public async Task<Sala> GetSalaAsync(Guid id)
            => await this.Context.Salas
                              .Include(x => x.Id)
                              .Where(x => x.Id == id)
                              .FirstOrDefaultAsync();

        public async Task RemoveAsync(Sala sala)
        {
            this.Context.Salas.Remove(sala);
            await this.Context.SaveChangesAsync();
        }
    }
}
