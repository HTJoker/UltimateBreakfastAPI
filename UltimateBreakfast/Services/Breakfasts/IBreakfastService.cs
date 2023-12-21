using ErrorOr;
using UltimateBreakfast.Models;

namespace UltimateBreakfast.Services.Breakfasts;

public interface IBreakfastService
{
  void CreateBreakfast(Breakfast breakfast);
  void DeleteBreakfast(Guid id);
  ErrorOr<Breakfast> GetBreakfast(Guid id);
  void UpsertBreakfast(Breakfast breakfast);
}