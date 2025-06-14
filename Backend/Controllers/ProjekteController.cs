using Backend.Data;
using Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProjekteController(AppDbContext context) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Standort>>> GetProjekte()
    {
        return await context.Standorte.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<Standort>> CreateProjekt(Standort projekt)
    {
        if (string.IsNullOrWhiteSpace(projekt.Name))
        {
            return BadRequest("Projektname darf nicht leer sein.");
        }

        context.Projekte.Add(projekt);
        await context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetProjekte), new { id = projekt.Id }, projekt);
    }
}