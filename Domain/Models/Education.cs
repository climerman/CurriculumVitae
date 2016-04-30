using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class Education
    {
        public int EducationId { get; set; }
        public string EducationValue { get; set; }

        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }

        [ForeignKey(nameof(EducationType))]
        public int EducationTypeId { get; set; }
        public virtual EducationType EducationType { get; set; }

        [ForeignKey(nameof(Person))]
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
    }
}