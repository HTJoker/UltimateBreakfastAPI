using ErrorOr;

namespace UltimateBreakfast.ServiceErrors;

public static class Errors
{
  public static class Breakfast
  {
    public static Error InvalidName => Error.Validation(
        code: "Breakfast.InvalidName",
        description: $"Breakfast name must be between {Models.Breakfast.MinNameLength} and {Models.Breakfast.MaxNameLength} characters.");

    public static Error InvalidDescription => Error.Validation(
        code: "Breakfast.InvalidDescription",
        description: $"Breakfast name must be between {Models.Breakfast.MinDescriptionLength} and {Models.Breakfast.MaxDescriptionLength} characters.");

    public static Error NotFound => Error.NotFound(
        code: "breakfast_not_found",
        description: "Breakfast not found.");
  }
}