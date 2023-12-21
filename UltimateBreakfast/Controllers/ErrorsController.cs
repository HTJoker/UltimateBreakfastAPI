using Microsoft.AspNetCore.Mvc;

namespace UltimateBreakfast.Controllers;

public class ErrorsController : ControllerBase
{
  [Route("/error")]
  public IActionResult Error()
  {
    return Problem();
  }
}