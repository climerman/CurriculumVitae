using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Domain.Models
{
    public class ExperienceType
    {
        public int ExperienceTypeId { get; set; }
        public string ExperienceTypeName { get; set; }

        public virtual ObservableCollection<Experience> Experiences { get; set; }
    }
}