using Microsoft.EntityFrameworkCore;
using VeryComplexApp.Api.Models;

namespace VeryComplexApp.Api.Infrastructure;

public class PersonsRepository(ComplexDbContext context) : IPersonsRepository
{
    public async Task<Person> GetPersonAsync(int id)
    {
        return await context.Persons.FirstAsync(x => x.Id == id);
    }

    public async Task<int> AddPersonAsync(Person person)
    {
        context.Persons.Add(person);
        await context.SaveChangesAsync();

        return person.Id;
    }
}