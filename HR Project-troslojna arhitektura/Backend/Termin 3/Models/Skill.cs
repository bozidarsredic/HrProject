using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Termin_6.Models
{
    public class Skill
    {
        public int id { get; set; }
        public string skillName { get; set; }
        public List<Candidat> Candidats { get; set; }
    }
}
