using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Termin_6.Dto;
using Termin_6.Models;

namespace Termin_6.Interfaces
{
  public  interface ICandidatService
    {
        void CreateCandidat(CandidatDto newUser);
        CandidatDto GetUserById(int id);
        List<CandidatDto> GetAllCandidats();
        void DeleteCandidat(int id);
    }
}
