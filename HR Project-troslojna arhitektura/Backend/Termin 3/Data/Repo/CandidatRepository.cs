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
    public class CandidatRepository : ICandidatRepository
    {
        private readonly IMapper mapper;
      
        private readonly DataContext dc;

        
        public CandidatRepository(IMapper mapper, DataContext dc)
        {
            this.mapper = mapper;
          
            this.dc = dc;
        }
        public void CreateCandidat(Candidat newCandidat)
        {
           dc.Candidats.Add(newCandidat);
           dc.SaveChanges();
        }

        public  List<Candidat> GetAllCandidats()
        {
            return dc.Candidats.ToList();
        }

        public Candidat GetUserById(int id)
        {
            return dc.Candidats.FirstOrDefault(x => x.id == id);
        }

        public void DeleteCandidat(int id)
        {
            foreach (var pom in dc.Candidats.ToList())
            {
                if (pom.id == id)
                {
                    dc.Candidats.Remove(pom);
                    dc.SaveChanges();
                    break;
                }

            }

            foreach (var pom in dc.CandidatSkills.ToList())
            {
                if (pom.Candidatsid == id)
                {
                    dc.CandidatSkills.Remove(pom);
                    dc.SaveChanges();

                }

            }

        }


    }
}
