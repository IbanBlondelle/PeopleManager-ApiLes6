﻿using PeopleManager.Dto.Results;
using PeopleManager.Model;

namespace PeopleManager.Services.Extensions
{
    public static class QueryableExtensions
    {
        public static IQueryable<PersonResult> ProjectToPersonResults(this IQueryable<Person> query)
        {
            return query.Select(p => new PersonResult
            {
                Id = p.Id,
                FirstName = p.FirstName,
                LastName = p.LastName,
                Email = p.Email,
                Description = p.Description,
                NumberOfResponsibleVehicles = p.ResponsibleForVehicles.Count
            });
        }
    }
}
