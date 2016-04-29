using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Sex? Sex { get; set; }
        public DateTime? BirthDate { get; set; }

        public virtual List<Contact> Contacts { get; set; }
        public virtual List<Education> Educations { get; set; }
        public virtual List<Experience> Experiences { get; set; }
        public virtual List<Skill> Skills { get; set; }

        public string FirstLastname => Firstname + " " + Lastname;
    }

    public enum Sex
    {
        Male = 1,
        Female
    }
}