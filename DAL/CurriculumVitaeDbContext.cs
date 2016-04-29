using System.Data.Entity;
using DAL.Interfaces;
using Domain.Models;

namespace DAL
{
    public class CurriculumVitaeDbContext : DbContext, IDbContext
    {
        public CurriculumVitaeDbContext() : base("name=CurriculumVitaeDb_Koiduste")
        {
            Database.SetInitializer(new DbInit());
        }



        public IDbSet<Person> Persons { get; set; }
        public IDbSet<Contact> Contacts { get; set; }
        public IDbSet<ContactType> ContactTypes { get; set; }
        public IDbSet<Education> Educations { get; set; }
        public IDbSet<EducationType> EducationTypes { get; set; }
        public IDbSet<Experience> Experiences { get; set; }
        public IDbSet<ExperienceType> ExperienceTypes { get; set; }
        public IDbSet<Skill> Skills { get; set; }
        public IDbSet<SkillType> SkillTypes { get; set; }
    }
}