using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Termin_6.Models
{
    public class Candidat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        public string Email { get; set; }
        public int  ContactNumber { get; set; }
        public List<Skill> Skills { get; set; }
      
    }
}
