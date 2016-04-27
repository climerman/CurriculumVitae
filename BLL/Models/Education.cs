using System.ComponentModel.DataAnnotations.Schema;

namespace BLL.Models
{
    public class Education
    {
        public int EducationId { get; set; }
        public string EducationValue { get; set; }

        [ForeignKey(nameof(EducationType))]
        public int EducationTypeId { get; set; }
        public EducationType EducationType { get; set; }

        [ForeignKey(nameof(Person))]
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}