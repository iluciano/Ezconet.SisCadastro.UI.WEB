using Ezconet.SisCadastro.UI.WEB.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Ezconet.SisCadastro.UI.WEB.Repositorio
{
    public class AnimalMODMap : EntityTypeConfiguration<AnimalMOD>
    {
        public AnimalMODMap()
        {
            ToTable("Animal");

            HasKey(x => x.CodAnimal);

            Property(x => x.NomeAnimal)
                .HasColumnType("varchar")
                .HasMaxLength(250);
        }
    }
}