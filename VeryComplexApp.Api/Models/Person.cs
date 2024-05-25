namespace VeryComplexApp.Api.Models;

public class Person
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string LastName { get; set; }
    public required DateTime DateOfBirth { get; set; }
}