using ArForEducationWebApi.Dto.Image;
using ArForEducationWebApi.Dto.Sequence;
using ArForEducationWebApi.Services;
using ArForEducationWebApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ArForEducationWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class SequenceController : ControllerBase
{
    private readonly ISequenceService _sequenceService;

    public SequenceController(ISequenceService sequenceService)
    {
        _sequenceService = sequenceService;
    }

    [HttpPost]
    public async Task<IActionResult> Post(CreateSequenceDto input)
    {
        await _sequenceService.CreateAsync(input);
        return Ok();
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var sequences = _sequenceService.GetAll();
        return Ok(sequences);
    }
    
    [HttpGet("{id:long}")]
    public async Task<IActionResult> Get(long id)
    {
        var sequence = await _sequenceService.GetAsync(id);
        return Ok(sequence);
    }
}