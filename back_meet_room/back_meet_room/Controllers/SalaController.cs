using AutoMapper;
using back_meet_room.Model;
using back_meet_room.Repository;
using back_meet_room.ViewModel.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace back_meet_room.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalaController : ControllerBase
    {
        private SalaRepository SalaRepository { get; init; }

        private IMapper Mapper { get; set; }

        public SalaController(SalaRepository salaRepository, IMapper mapper)
        {
            this.SalaRepository = salaRepository;
            Mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetSala()
        {
            return Ok(await this.SalaRepository.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSala(Guid id)
        {
            var result = await this.SalaRepository.GetSalaByIdAsync(id);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> SaveSala(SalaRequest request)
        {
            if (ModelState.IsValid == false)
                return BadRequest(ModelState);

            Sala sala = this.Mapper.Map<Sala>(request);

            await this.SalaRepository.CreateAsync(sala);

            return Created($"/{sala.Id}", sala);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveSala(Guid id)
        {
            var sala = await this.SalaRepository.GetSalaAsync(id);

            if (sala == null)
                return UnprocessableEntity(new { Message = "Sala not found" });

            await this.SalaRepository.RemoveAsync(sala);

            return NoContent();
        }
    }
}
