using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Termin_6.Models;

namespace Termin_6.Data.Configurations
{
    public class CandidatStilConfiguration : IEntityTypeConfiguration<CandidatSkill>
    {

        

        public void Configure(EntityTypeBuilder<CandidatSkill> builder)
        {
            builder.HasKey(x => x.id); //Podesavam primarni kljuc tabele
            builder.Property(x => x.id).ValueGeneratedOnAdd(); //Kazem da ce se primarni kljuc
                                                               //automatski generisati prilikom dodavanja,
                                                               //redom 1 2 3...

        }


        //automatski generisati prilikom dodavanja,
        //redom 1 2 3...


    }
}
