using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Termin_6.Models;

namespace Termin_6.Dto
{
    public class SkillDto
    {

        public int id { get; set; }
        public string skillName { get; set; }
        List<CandidatSkill> Candidats { get; set; }
    }
}
