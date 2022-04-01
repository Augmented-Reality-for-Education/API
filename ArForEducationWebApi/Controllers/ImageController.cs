using ArForEducationWebApi.Dto.Image;
using ArForEducationWebApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ArForEducationWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ImageController : ControllerBase
{
    private readonly IImageService _imageService;

    public ImageController(IImageService imageService)
    {
        _imageService = imageService;
    }
    
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_imageService.GetAll());
    }

    [HttpPut]
    public async Task<IActionResult> Put(CreateImageDto input)
    {
        var newImage = await _imageService.CreateAsync(input);
        return Ok(newImage);
    }
}