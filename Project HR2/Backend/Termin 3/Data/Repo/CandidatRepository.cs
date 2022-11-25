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
        public void CreateCandidat(CandidatDto newCandidat)
        {




          //  dobavim  candidat i skil id i onda nadjem objekat tog candidata i u njegovu listu dodam skil.
           // candidats.Add(newUser);

          //
          

           dc.Candidats.Add(mapper.Map<Candidat>(newCandidat));
           dc.SaveChanges();

            
        }

        

        public  List<Candidat> GetAllCandidats()
        {
            return dc.Candidats.ToList();
        }

        public CandidatDto GetUserById(int id)
        {
            return mapper.Map<CandidatDto>(dc.Candidats.FirstOrDefault(x => x.Id == id));
        }

        public void DeleteCandidat(int id)
        {
            //  dc.Candidats.Remove((mapper.Map<Candidat>(GetUserById(id))));
            //  dc.SaveChanges();

            foreach (var pom in dc.Candidats.ToList())
            {
                if (pom.Id == id)
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
