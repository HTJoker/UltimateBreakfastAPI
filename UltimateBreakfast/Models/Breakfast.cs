using ErrorOr;
using UltimateBreakfast.ServiceErrors;
namespace UltimateBreakfast.Models;


public class Breakfast(
  Guid id,
  string name,
  string description,
  DateTime startDate,
  DateTime endDate,
  DateTime lastUpdated,
  List<string> savory,
  List<string> sweet
  )
{
  public const int MinNameLength = 3;
  public const int MaxNameLength = 50;

  public const int MinDescriptionLength = 50;
  public const int MaxDescriptionLength = 150;

  public Guid Id { get; } = id;
  public string Name { get; } = name;
  public string Description { get; } = description;
  public DateTime StartDate { get; } = startDate;
  public DateTime EndDate { get; } = endDate;
  public DateTime LastUpdated { get; } = lastUpdated;
  public List<string> Savory { get; } = savory;
  public List<string> Sweet { get; } = sweet;

  public static ErrorOr<Breakfast> Create(
    string name,
    string description,
    DateTime startDate,
    DateTime endDate,
    List<string> savory,
    List<string> sweet,
    Guid? id = null
    )
  {
    if (name.Length < MinNameLength || name.Length > MaxNameLength)
    {
      return Errors.Breakfast.InvalidName;
    }

    if (description.Length < MinDescriptionLength || description.Length > MaxDescriptionLength)
    {
      return Errors.Breakfast.InvalidDescription;
    }

    return new Breakfast(
      id ?? Guid.NewGuid(),
      name,
      description,
      startDate,
      endDate,
      DateTime.UtcNow,
      savory,
      sweet
      );
  }
}
