using AGP.MultiSearch.API.Dtos;
using AGP.MultiSearch.API.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace AGP.MultiSearch.API.Controllers;

[Route("main")]
[ApiController]
public class MainController : ControllerBase
{
    private readonly IMainService _mainService;

    public MainController(IMainService mainService)
    {
        _mainService = mainService;
    }

    [HttpGet()]
    public IActionResult Get([FromQuery] string textToSearch)
    {
        try
        {
            SearchObjectsDto dto = _mainService.Search(textToSearch);
            return Ok(dto);
        }
        catch (Exception ex)
        {
            return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
        }
    }
}
