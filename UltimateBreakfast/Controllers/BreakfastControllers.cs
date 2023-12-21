using ErrorOr;
using Microsoft.AspNetCore.Mvc;
using UltimateBreakfast.Contracts.Breakfast;
using UltimateBreakfast.Models;
using UltimateBreakfast.ServiceErrors;
using UltimateBreakfast.Services.Breakfasts;

namespace UltimateBreakfast.Controllers;


public class BreakfastController(IBreakfastService breakfastService) : ApiController
{
  private readonly IBreakfastService _breakfastService = breakfastService;

  [HttpPost()]
  public IActionResult CreateBreakfast(CreateBreakfastRequest request)
  {
    var breakfast = new Breakfast(
      Guid.NewGuid(),
      request.Name,
      request.Description,
      request.StartDate,
      request.EndDate,
      DateTime.UtcNow,
      request.Savory,
      request.Sweet
    );

    _breakfastService.CreateBreakfast(breakfast);

    var response = new BreakfastResponse(
      breakfast.Id,
      breakfast.Name,
      breakfast.Description,
      breakfast.StartDate,
      breakfast.EndDate,
      breakfast.LastUpdated,
      breakfast.Savory,
      breakfast.Sweet
    );

    ErrorOr<Created> createBreakfastResult = _breakfastService.CreateBreakfast(breakfast);
    return createBreakfastResult.Match(
      created => CreatedAtGetBreakfast(breakfast),
      errors => Problem(errors));
  }



  [HttpGet("{id:guid}")]
  public IActionResult GetBreakfast(Guid id)
  {
    ErrorOr<Breakfast> getBreakfastResult = _breakfastService.GetBreakfast(id);

    return getBreakfastResult.Match(
      breakfast => Ok(MapBreakfastResponse(breakfast)),
      errors => Problem(errors));

  }

  [HttpPut("{id:guid}")]
  public IActionResult UpsertBreakfast(Guid id, UpsertBreakfastRequest request)
  {
    var breakfast = new Breakfast(
      Guid.NewGuid(),
      request.Name,
      request.Description,
      request.StartDate,
      request.EndDate,
      DateTime.UtcNow,
      request.Savory,
      request.Sweet
    );

    ErrorOr<UpsertedBreakfast> upsertedResult = _breakfastService.UpsertBreakfast(breakfast);

    return upsertedResult.Match(
      upserted => upserted.IsNewlyCreated ? CreatedAtGetBreakfast(breakfast) : NoContent(),
      errors => Problem(errors));

  }

  [HttpDelete("{id:guid}")]
  public IActionResult DeleteBreakfast(Guid id)
  {
    ErrorOr<Deleted> deletedResult = _breakfastService.DeleteBreakfast(id);

    return deletedResult.Match(
      deleted => NoContent(),
      errors => Problem(errors));
  }


  private static BreakfastResponse MapBreakfastResponse(Breakfast breakfast)
  {
    return new BreakfastResponse(
          breakfast.Id,
          breakfast.Name,
          breakfast.Description,
          breakfast.StartDate,
          breakfast.EndDate,
          breakfast.LastUpdated,
          breakfast.Savory,
          breakfast.Sweet
        );
  }

  private IActionResult CreatedAtGetBreakfast(Breakfast breakfast)
  {
    return CreatedAtAction(
      actionName: nameof(GetBreakfast),
      routeValues: new { id = breakfast.Id },
      value: MapBreakfastResponse(breakfast));
  }

}