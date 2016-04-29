using System.Collections.Generic;

namespace Domain.Models
{
    public class ExperienceType
    {
        public int ExperienceTypeId { get; set; }
        public string ExperienceTypeName { get; set; }

        public virtual List<Experience> Experiences { get; set; }
    }
}