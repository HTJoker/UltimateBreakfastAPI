namespace UltimateBreakfast.Contracts.Breakfast;

public record BreakfastResponse(
    Guid Id,
    string Name,
    string Description,
    DateTime StartDate,
    DateTime EndDate,
    DateTime LastUpdated,
    List<string> Savory,
    List<string> Sweet
);