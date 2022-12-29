﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Termin_6.Models;

namespace Termin_6.Dto
{
    public class CandidatDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public string dateOfBirth { get; set; }
        public string email { get; set; }
        public int contactNumber { get; set; }

        public List<Skill> Skills { get; set; }

    }
}
