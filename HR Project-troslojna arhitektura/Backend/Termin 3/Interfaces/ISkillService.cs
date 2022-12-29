using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Termin_6.Dto;
using Termin_6.Models;

namespace Termin_6.Interfaces
{
    public interface ISkillService
    {
        void CreateSkill(SkillDto skil);
        void AddSkillToCandidat(CandidatSkillDto skil);
        List<SkillDto> GetAllSkills();
        List<SkillDto> GetSkillsById(int id);
        List<SkillDto> GetAvailableSkillsById(int id);
        void DeleteSkillToCandidat(CandidatSkillDto skil);
    }
}
