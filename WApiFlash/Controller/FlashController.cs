using Microsoft.AspNetCore.Mvc;
using WApiFlash.Model;
using WApiFlash.Repository;

namespace WApiFlash.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class FlashController : ControllerBase
    {
        private readonly IGenericRepository<Flash> _repository;
        public FlashController(IGenericRepository<Flash> repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Flash>>> GetFlashs()
        {
            var games = await _repository.GetAllAsync();
            return Ok(games);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Flash>> GetFlash(int id)
        {
            var flash = await _repository.GetByIdAsync(id);
            if (flash == null)
                return NotFound();
            return Ok(flash);
        }
        [HttpPost]
        public async Task<ActionResult<Flash>> CreateFlash(Flash flash)
        {
            var newFlash = await _repository.AddAsync(flash);
            return CreatedAtAction(nameof(GetFlash), new {id=newFlash.Id},newFlash);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateGame(Flash flash)
        {
            await _repository.UpdateAsync(flash);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGame(int id)
        {
            var existingFlash = await _repository.GetByIdAsync(id);
            if (existingFlash == null)
                return NotFound();

            await _repository.DeleteAsync(id);
            return NoContent();
        }
    }
}
