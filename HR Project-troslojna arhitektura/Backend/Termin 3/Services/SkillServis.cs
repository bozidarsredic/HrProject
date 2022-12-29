using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Termin_6.Data;
using Termin_6.Dto;
using Termin_6.Interfaces;
using Termin_6.Models;

namespace Termin_6.Services
{
    public class SkillServis : ISkillService
    {
        private readonly IMapper mapper;

        
        private readonly IUnitOfWork uow;


        public SkillServis(IMapper mapper, IUnitOfWork uow)
        {
            this.mapper = mapper;
            this.uow = uow;
        }

        public void CreateSkill(SkillDto skil)
        {
           uow.SkillRepository.CreateSkill(mapper.Map<Skill>(skil));
        }
        public List<SkillDto> GetAllSkills()
        {
            return mapper.Map<List<SkillDto>>(uow.SkillRepository.GetAllSkills());
        }

        public void AddSkillToCandidat(CandidatSkillDto skil)
        {
            uow.SkillRepository.AddSkillToCandidat(mapper.Map<CandidatSkill>(skil));
        }

        public List<SkillDto> GetSkillsById(int id)
        {
            return mapper.Map<List<SkillDto>>(uow.SkillRepository.GetSkillsById(id));

        }

         public List<SkillDto> GetAvailableSkillsById(int id)
        {
           return mapper.Map <List<SkillDto>>(uow.SkillRepository.GetAvailableSkillsById(id));
           
        }

        public void DeleteSkillToCandidat(CandidatSkillDto skil)
        {
           uow.SkillRepository.DeleteSkillToCandidat(mapper.Map<CandidatSkill>(skil));
        }
    
    }
}
