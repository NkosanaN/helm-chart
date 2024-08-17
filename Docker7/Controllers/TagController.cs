using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Docker7.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TagController(ILogger<TagController> logger, DataContext context) : ControllerBase
{
    // GET: api/<InfoController>
    private readonly ILogger<TagController> _logger = logger;
    private readonly DataContext _context = context;

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Tag>>> GetTagAsync()
    {
        var tags = await _context.Tag.ToListAsync();

        _logger.Log(LogLevel.Information, "Getting Tags");

        return Ok(tags);
    }
}
