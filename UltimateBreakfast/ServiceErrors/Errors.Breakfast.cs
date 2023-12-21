using ErrorOr;

namespace UltimateBreakfast.ServiceErrors;

public static class Errors
{
  public static class Breakfast
  {
    public static Error NotFound => Error.NotFound(
        code: "breakfast_not_found",
        description: "Breakfast not found.");
  }
}