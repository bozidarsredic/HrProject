using AutoMapper;
using Microsoft.Extensions.Configuration;
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
    public class CandidatServis: ICandidatService
    {
        private readonly IMapper mapper;

        
        
        private readonly IUnitOfWork uow;

        public CandidatServis(IMapper mapper, IUnitOfWork uow)
        {
            this.mapper = mapper;
           this.uow = uow;
        }

        public void CreateCandidat(CandidatDto newCandidat)
        {
           uow.CandidatRepository.CreateCandidat(mapper.Map<Candidat>(newCandidat));
        }

       public List<CandidatDto> GetAllCandidats()
        {
            return mapper.Map<List<CandidatDto>>(uow.CandidatRepository.GetAllCandidats());
        }

        public CandidatDto GetUserById(int id)
        {
            return mapper.Map<CandidatDto>(uow.CandidatRepository.GetUserById(id));
        }

        public void DeleteCandidat(int id)
        {
             uow.CandidatRepository.DeleteCandidat(id);
        }
    
    }
}
