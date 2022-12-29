using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Termin_6.Dto;
using Termin_6.Models;

namespace Termin_6.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Candidat, CandidatDto>().ReverseMap();
            CreateMap<Skill, SkillDto>().ReverseMap();
            CreateMap<CandidatSkill, CandidatSkillDto>().ReverseMap();
        }
    }
}
