using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;
using DAL;
using DAL.Interfaces;
using DAL.Repositories;
using Domain.Models;

namespace BLL.Services
{
    public class PersonService : IPersonService
    {
        private readonly IRepository<Person> _personRepository = new Repository<Person>(new CurriculumVitaeDbContext());

        public List<Person> LoadPersons() => _personRepository.GetAll();
    }
}