using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Termin_6.Models;

namespace Termin_6.Data.Configurations
{
    public class CandidatConfiguration : IEntityTypeConfiguration<Candidat>
    {
        public void Configure(EntityTypeBuilder<Candidat> builder)
        {
            builder.HasKey(x => x.Id); //Podesavam primarni kljuc tabele

            builder.Property(x => x.Id).ValueGeneratedOnAdd(); //Kazem da ce se primarni kljuc
                                                               //automatski generisati prilikom dodavanja,
                                                               //redom 1 2 3...

                      builder.HasMany(x => x.Skills) //Candidat ima vise skilova
                   .WithMany(x => x.Candidats);//jedan skil moze biti kod vise kandidata

        }
    }
}
