using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Termin_6.Models;

namespace Termin_6.Data
{
    public class DataContext : DbContext
    {
        // public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Candidat> Candidats { get; set; }

        public DbSet<Skill> Skills { get; set; }

        public DbSet<CandidatSkill> CandidatSkills { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Kazemo mu da pronadje sve konfiguracije u Assembliju i da ih primeni nad bazom
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);
        }



    }
}
