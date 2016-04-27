using System.ComponentModel.DataAnnotations.Schema;

namespace BLL.Models
{
    public class Skill
    {
        public int SkillId { get; set; }
        public string SkillValue { get; set; }

        [ForeignKey(nameof(SkillType))]
        public int SkillTypeId { get; set; }
        public SkillType SkillType { get; set; }

        [ForeignKey(nameof(Person))]
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}