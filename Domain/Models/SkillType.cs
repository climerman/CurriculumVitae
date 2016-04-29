using System.Collections.Generic;

namespace Domain.Models
{
    public class SkillType
    {
        public int SkillTypeId { get; set; }
        public string SkillTypeName { get; set; }

        public virtual List<Skill> Skills { get; set; }
    }
}