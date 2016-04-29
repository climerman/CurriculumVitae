using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class Skill
    {
        public int SkillId { get; set; }
        public string SkillValue { get; set; }
        public string SkillRating { get; set; }

        [ForeignKey(nameof(SkillType))]
        public int SkillTypeId { get; set; }
        public virtual SkillType SkillType { get; set; }

        [ForeignKey(nameof(Person))]
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
    }
}