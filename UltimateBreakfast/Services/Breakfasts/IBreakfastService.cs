using UltimateBreakfast.Models;

namespace UltimateBreakfast.Services.Breakfasts;

public interface IBreakfastService
{
  void CreateBreakfast(Breakfast breakfast);
  Breakfast GetBreakfast(Guid id);
}