using AutoMapper;
using ChineseEmperors.Server.Data;
using ChineseEmperors.Server.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ChineseEmperors.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChineseEmperorController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public ChineseEmperorController(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<ChineseEmperor>>> GetAllEmperors()
        {
            var Emperors = await _context.ChineseEmperors.ToListAsync();
            
            return Ok(Emperors);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ChineseEmperor>> GetAllEmperorsById(int id)
        {
            var Emperors = await _context.ChineseEmperors.FirstOrDefaultAsync(e=>e.Id==id);

            if(Emperors is null)
            {
                return NotFound($"No Emperor found with id {id}");
            }

            return Ok(Emperors);
        }

        [HttpPost]
        public async Task<ActionResult<List<ChineseEmperor>>> AddEmperors(ChineseEmperor chineseEmperor)
        {
            _context.ChineseEmperors.Add(chineseEmperor);
            await _context.SaveChangesAsync();
            return Ok(chineseEmperor);
        }

        [HttpPut]
        public async Task<ActionResult<List<ChineseEmperor>>> UpdateEmperors(ChineseEmperor updateChineseEmperor)
        {
            var Emperors = await _context.ChineseEmperors.FindAsync(updateChineseEmperor.Id);

            if (Emperors is null)
            {
                return NotFound($"No Emperor found with id {updateChineseEmperor.Id}");
            }

            _mapper.Map(updateChineseEmperor, Emperors);

            await _context.SaveChangesAsync();

            return Ok(Emperors);

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ChineseEmperor>> DeleteEmperorsById(int id)
        {
            var Emperors = await _context.ChineseEmperors.FirstOrDefaultAsync(e => e.Id == id);

            if (Emperors is null)
            {
                return NotFound($"Cannot delete Emperor, no record exist with id {id}");
            }

            _context.Remove(Emperors);

            await _context.SaveChangesAsync();

            return Ok("Deleted"+Emperors);
        }

    }
}
