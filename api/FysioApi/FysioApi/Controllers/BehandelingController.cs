using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VerkisListDatabaseHandler.Data;
using VerkisListDatabaseHandler.Models;

namespace FysioApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class BehandelingController : ControllerBase
    {
        private readonly ILogger<BehandelingController> _logger;
        private readonly VerkisContext _context;

        public BehandelingController(ILogger<BehandelingController> logger, VerkisContext context)
        {
            _logger = logger;
            _context = context;
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<Verrichting>> GetAll()
        {
            return Ok(_context.Verrichtingen);
        }

        [HttpGet("{code}")]
        public ActionResult<Verrichting> GetOne(string code)
        {
            foreach (Verrichting v in _context.Verrichtingen)
                if (v.Waarde.Equals(code))
                    return Ok(v);
            return NotFound();
        }

        [HttpGet("some/{code}")]
        public ActionResult<List<Verrichting>> GetSome(string code)
        {
            List<Verrichting> verrichtings = new();
            foreach (Verrichting v in _context.Verrichtingen)
                if (v.Waarde.StartsWith(code))
                    verrichtings.Add(v);
            if (verrichtings.Count != 0)
                return Ok(verrichtings);
            return NotFound();
        }
    }
}
