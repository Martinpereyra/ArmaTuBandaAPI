using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class InstrumentosController : ControllerBase
{
    private readonly DataContext _context;
    public InstrumentosController(DataContext context)
    {
            _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Instrumento>>> GetTipos()
    {
        return await _context.Instrumentos.ToListAsync();
    } 

}
