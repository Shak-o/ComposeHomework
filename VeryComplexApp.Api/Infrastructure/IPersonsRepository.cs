using VeryComplexApp.Api.Models;

namespace VeryComplexApp.Api.Infrastructure;

public interface IPersonsRepository
{
    Task<Person> GetPersonAsync(int id);
    Task<int> AddPersonAsync(Person person);
}