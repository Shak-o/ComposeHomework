using Microsoft.AspNetCore.Mvc;
using VeryComplexApp.Api.Infrastructure;
using VeryComplexApp.Api.Models;

namespace VeryComplexApp.Api.Controllers;

public class ComplexController (IPersonsRepository personsRepository)
{
    [HttpPost("ComplexSave")]
    public Task<int> SaveAsync(Person person)
        => personsRepository.AddPersonAsync(person);

    [HttpGet("ComplexGet")]
    public Task<Person> GetPerson(int id)
        => personsRepository.GetPersonAsync(id);


}