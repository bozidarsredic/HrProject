using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Termin_6.Dto;
using Termin_6.Models;

namespace Termin_6.Interfaces
{
  public   interface ISkillRepository
    {
        void CreateSkill(Skill skil);
        void AddSkillToCandidat(CandidatSkill skil);
        List<Skill> GetAllSkills();
        List<Skill> GetSkillsById(int id);
        List<Skill> GetAvailableSkillsById(int id);
        Skill GetSkillById(int id);
        void DeleteSkillToCandidat(CandidatSkill skil);
    }
}
