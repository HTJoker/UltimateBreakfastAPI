using ErrorOr;
using UltimateBreakfast.Models;
using UltimateBreakfast.ServiceErrors;
namespace UltimateBreakfast.Services.Breakfasts;

public class BreakfastService : IBreakfastService
{

  private static readonly Dictionary<Guid, Breakfast> _breakfasts = [];

  public void CreateBreakfast(Breakfast breakfast)
  {
    _breakfasts.Add(breakfast.Id, breakfast);
  }

  public void DeleteBreakfast(Guid id)
  {
    _breakfasts.Remove(id);
  }

  public ErrorOr<Breakfast> GetBreakfast(Guid id)
  {
    if (_breakfasts.TryGetValue(id, out var breakfast))
    {
      return breakfast;
    }
    return Errors.Breakfast.NotFound;
  }

  public void UpsertBreakfast(Breakfast breakfast)
  {
    _breakfasts.Add(breakfast.Id, breakfast);
  }
}