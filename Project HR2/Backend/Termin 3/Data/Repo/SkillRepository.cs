using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Termin_6.Interfaces;
using AutoMapper;
using Microsoft.Extensions.Configuration;


using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Termin_6.Dto;
using Termin_6.Models;

namespace Termin_6.Data.Repo
{
    public class SkillRepostitory : ISkillRepository
    {
        private readonly IMapper mapper;

        private readonly DataContext dc;

        List<Skill> mySkills;
        List<Skill> availableSkills;

        public SkillRepostitory(IMapper mapper, DataContext dc)
        {
            this.mapper = mapper;

            this.dc = dc;
        }

      

        public void CreateSkill(SkillDto newUser)
        {


             dc.Skills.Add(mapper.Map<Skill>(newUser));
             dc.SaveChanges();

        }

        public List<Skill> GetAllSkills()
        {
            return dc.Skills.ToList();
        }

        public void AddSkillToCandidat(CandidatSkillDto skil)
        {

           dc.CandidatSkills.Add(mapper.Map<CandidatSkill>(skil));
            dc.SaveChanges();

            // dc.Candidats.FirstOrDefault(x => x.id == skil.Candidatsid).Skills.Add(dc.Skills.FirstOrDefault(x => x.id == skil.Skillsid));
         //   dc.SaveChanges();
           
        }

        public List<Skill> GetSkillsById(int id)
        {
            
           
            mySkills = new List<Skill>();
            foreach (var pom in dc.CandidatSkills.ToList()) {

                if (pom.Candidatsid == id) {
                    mySkills.Add(GetSkillById(pom.Skillsid));
                }
            }

            return mySkills;
        }

        public Skill GetSkillById(int id)
        {
            return dc.Skills.FirstOrDefault(x => x.Id == id);
        }

        public List<Skill> GetAvailableSkillsById(int id)
        {
            int counter = 0;
            availableSkills = new List<Skill>();

            foreach (var pom in dc.Skills.ToList()) {

                foreach (var pom2 in GetSkillsById(id)) {

                    if (pom.Id == pom2.Id) {
                        counter = 1;
                    }
                
                }
                if (counter == 0)
                {
                    availableSkills.Add(pom);
                }
                else
                {
                    counter = 0;
                }
            }


            return availableSkills;
        }

        public void DeleteSkillToCandidat(CandidatSkillDto skil)
        {

            foreach (var pom in dc.CandidatSkills.ToList()) {
                if (pom.Skillsid == skil.Skillsid && pom.Candidatsid == skil.Candidatsid) {
                    dc.CandidatSkills.Remove(pom);
                    dc.SaveChanges();
                    break;
                }

            }

       
        }
    }
}
