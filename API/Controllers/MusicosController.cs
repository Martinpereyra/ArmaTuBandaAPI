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
public class MusicosController : ControllerBase
{
    private readonly DataContext _context;
    public MusicosController(DataContext context)
    {
            _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Musico>>> GetMusicos()
    {
        return await _context.Musicos.ToListAsync();

    }

    
    [HttpGet("{id}")]
    public async Task<ActionResult<Musico>> GetUser(int id)
    {
        return await _context.Musicos.FindAsync(id);

    }
}
