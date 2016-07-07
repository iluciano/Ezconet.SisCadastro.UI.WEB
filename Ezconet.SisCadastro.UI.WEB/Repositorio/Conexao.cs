using Ezconet.SisCadastro.UI.WEB.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ezconet.SisCadastro.UI.WEB.Repositorio
{
    public class Conexao : DbContext
    {
        public Conexao()
            : base("adm_conteel")
        {}

        public DbSet<PessoaMOD> Pessoa { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PessoaMODMap());
            modelBuilder.Configurations.Add(new AnimalMODMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}