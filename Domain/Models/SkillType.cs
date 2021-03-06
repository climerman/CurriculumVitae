﻿using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Domain.Models
{
    public class SkillType
    {
        public int SkillTypeId { get; set; }
        public string SkillTypeName { get; set; }

        public virtual ObservableCollection<Skill> Skills { get; set; }
    }
}