using Ezconet.SisCadastro.UI.WEB.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Ezconet.SisCadastro.UI.WEB.Repositorio
{
    public class PessoaMODMap : EntityTypeConfiguration<PessoaMOD>
    {
        public PessoaMODMap()
        {
            ToTable("Pessoa");

            HasKey(x => x.CodPessoa);

            Property(x => x.NomePessoa)
                .HasColumnType("varchar")
                .HasMaxLength(250);
        }

    }
}