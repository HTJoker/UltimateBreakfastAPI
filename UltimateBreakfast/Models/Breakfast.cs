namespace UltimateBreakfast.Models;

public class Breakfast
{
  public Guid Id { get; }
  public string Name { get; }
  public string Description { get; }
  public DateTime StartDate { get; }
  public DateTime EndDate { get; }
  public DateTime LastUpdated { get; }
  public List<string> Savory { get; }
  public List<string> Sweet { get; }

  public Breakfast(
    Guid id,
    string name,
    string description,
    DateTime startDate,
    DateTime endDate,
    DateTime lastUpdated,
    List<string> savory,
    List<string> sweet)
  {
    Id = id;
    Name = name;
    Description = description;
    StartDate = startDate;
    EndDate = endDate;
    LastUpdated = lastUpdated;
    Savory = savory;
    Sweet = sweet;

  }
}
