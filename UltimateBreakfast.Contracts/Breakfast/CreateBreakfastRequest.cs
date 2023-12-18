namespace UltimateBreakfast.Contracts.Breakfast;

public record CreateBreakfastRequest(
    string Name,
    string Description,
    DateTime StartDate,
    DateTime EndDate,
    List<string> Savory,
    List<string> Sweet
);