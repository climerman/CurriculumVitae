using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BLL.Models
{
    public class Experience
    {
        public int ExperienceId { get; set; }
        public string ExperienceValue { get; set; }

        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }

        [ForeignKey(nameof(ExperienceType))]
        public int ExperienceTypeId { get; set; }
        public ExperienceType ExperienceType { get; set; }

        [ForeignKey(nameof(Person))]
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}