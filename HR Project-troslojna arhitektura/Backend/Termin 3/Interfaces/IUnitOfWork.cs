﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Termin_6.Interfaces
{
    public interface IUnitOfWork
    {
        Task<bool> SaveAsync();
        ICandidatRepository CandidatRepository { get; }
        ISkillRepository SkillRepository { get; }
     }
}
