using AutoMapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Termin_6.Data.Repo;
using Termin_6.Interfaces;

namespace Termin_6.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext dc;
        //private readonly IConfigurationSection _secretKey;
        private readonly IMapper mapper;
        public UnitOfWork(DataContext dc, IMapper mapper)
        {
            this.dc = dc;
            this.mapper = mapper;
            //this._secretKey = _secretKey.GetSection("SecretKey");
        }

        public ICandidatRepository CandidatRepository => new CandidatRepository(mapper, dc);

        public ISkillRepository SkillRepository => new SkillRepostitory(mapper, dc);

        public ICandidatRepository UserRepository => throw new NotImplementedException();

        public async Task<bool> SaveAsync()
        {
            return await dc.SaveChangesAsync() > 0;
        }
    }
}
