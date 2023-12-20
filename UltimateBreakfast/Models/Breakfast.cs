namespace UltimateBreakfast.Models;

public class Breakfast(
  Guid id,
  string name,
  string description,
  DateTime startDate,
  DateTime endDate,
  DateTime lastUpdated,
  List<string> savory,
  List<string> sweet)
{
    public Guid Id { get; } = id;
    public string Name { get; } = name;
    public string Description { get; } = description;
    public DateTime StartDate { get; } = startDate;
    public DateTime EndDate { get; } = endDate;
    public DateTime LastUpdated { get; } = lastUpdated;
    public List<string> Savory { get; } = savory;
    public List<string> Sweet { get; } = sweet;
}
