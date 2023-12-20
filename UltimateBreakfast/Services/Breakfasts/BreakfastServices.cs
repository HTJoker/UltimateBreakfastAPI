using UltimateBreakfast.Models;
namespace UltimateBreakfast.Services.Breakfasts;

public class BreakfastService : IBreakfastService
{

  private static readonly Dictionary<Guid, Breakfast> _breakfasts = [];

  public void CreateBreakfast(Breakfast breakfast)
  {
    _breakfasts.Add(breakfast.Id, breakfast);
  }

  public Breakfast GetBreakfast(Guid id)
  {
    return _breakfasts[id];
  }
}