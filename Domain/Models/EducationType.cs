using System.Collections.Generic;

namespace Domain.Models
{
    public class EducationType
    {
        public int EducationTypeId { get; set; }
        public string EducationTypeName { get; set; }

        public virtual List<Education> Educations { get; set; }
    }
}