using Microsoft.AspNetCore.Mvc;
using UltimateBreakfast.Contracts.Breakfast;

namespace UltimateBreakfast.Controllers;

[ApiController]
[Route("[controller]")]
public class BreakfastController : ControllerBase
{
  [HttpPost()]
  public IActionResult CreateBreakfast(CreateBreakfastRequest request)
  {
    return Ok(request);
  }

  [HttpGet("{id:guid}")]
  public IActionResult GetBreakfast(Guid id)
  {
    return Ok(id);
  }

  [HttpPut("{id:guid}")]
  public IActionResult UpsertBreakfast(Guid id, UpsertBreakfastRequest request)
  {
    return Ok(request);
  }

  [HttpDelete("{id:guid}")]
  public IActionResult DeleteBreakfast(Guid id)
  {
    return Ok(id);
  }

}