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

    //[HttpGet]
    //public IActionResult Get()
    //{
    //    return Ok(_sequenceService.GetAll());
    //}

    //[HttpGet("{id:long}")]
    //public async Task<IActionResult> Get(long id)
    //{
    //    var image = await _sequenceService.GetAsync(id);
    //    return Ok(image);
    //}

    //[HttpPut]
    //public async Task<IActionResult> Put(CreateImageDto input)
    //{
    //    var newImage = await _sequenceService.CreateAsync(input);
    //    return Ok(newImage);
    //}

    [HttpPost]
    public async Task<IActionResult> Post(CreateSequenceDto input)
    {
        await _sequenceService.CreateAsync(input);
        return Ok();
    }
}