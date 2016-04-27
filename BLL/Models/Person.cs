using System;
using System.Collections.Generic;

namespace BLL.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Sex Sex { get; set; }
        public DateTime BirthDate { get; set; }

        public List<Contact> Contacts { get; set; }
        public List<Education> Educations { get; set; }
        public List<Experience> Experiences { get; set; }
        public List<Skill> Skills { get; set; }
    }

    public enum Sex
    {
        Male = 1,
        Female
    }
}