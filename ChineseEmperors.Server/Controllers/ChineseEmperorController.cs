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
        public ChineseEmperorController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<ChineseEmperor>>> GetAllEmperors()
        {
            var Emperors = await _context.ChineseEmperors.ToListAsync();
            
            return Ok(Emperors);
        }
    }
}
