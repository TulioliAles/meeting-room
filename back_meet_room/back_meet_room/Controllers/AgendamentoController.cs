using AutoMapper;
using back_meet_room.Model;
using back_meet_room.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace back_meet_room.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgendamentoController : ControllerBase
    {
        private AgendamentoRepository AgendamentoRepository { get; set; }

        private IMapper Mapper { get; set; }
        public object AgendaRepository { get; private set; }

        public AgendamentoController(AgendamentoRepository repository, IMapper mapper)
        {
            this.AgendamentoRepository = repository;
            Mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAgenda()
        {
            return Ok(await this.AgendamentoRepository.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAgenda(Guid id)
        {
            var result = await this.AgendamentoRepository.GetAgendaByIdAsync(id);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> SaveAgenda(AgendaRequest request)
        {
            if (ModelState.IsValid == false)
                return BadRequest(ModelState);

            Agendamento agendamento = this.Mapper.Map<Agendamento>(request);

            await this.AgendamentoRepository.CreateAsync(agendamento);

            return Created($"/{agendamento.Id}", agendamento);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveAgendamento(Guid id)
        {
            var sala = await this.AgendamentoRepository.GetAgendamentoAsync(id);

            if (sala == null)
                return UnprocessableEntity(new { Message = "Sala not found" });

            await this.AgendamentoRepository.RemoveAsync(sala);

            return NoContent();
        }
    }
}
