using Bicycle.Models;
using Microsoft.AspNetCore.Mvc;
using Bicycle.Persistence;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Bicycle.Controllers.Resources;

namespace Bicycle.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MakesController : ControllerBase
{
    private readonly BicycleDbContext _context;
    private readonly IMapper _mapper;
 
    public MakesController(
        BicycleDbContext context,
        IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IEnumerable<MakeResource>> Get()
    {
        var makes = await _context.Makes!.Include(m => m.Models).ToListAsync();
        return _mapper.Map<List<Make>,List<MakeResource>>(makes);
    }
}
