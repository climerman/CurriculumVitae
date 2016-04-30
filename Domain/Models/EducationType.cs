using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Domain.Models
{
    public class EducationType
    {
        public int EducationTypeId { get; set; }
        public string EducationTypeName { get; set; }

        public virtual ObservableCollection<Education> Educations { get; set; }
    }
}