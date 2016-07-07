using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ezconet.SisCadastro.UI.WEB.Models
{
    public class PessoaMOD
    {
        [Key]
        public int CodPessoa { get; set; }

        [Required, Display(Name = "Nome")]
        public string NomePessoa { get; set; }

        [Required, Display(Name = "Sexo")]
        public byte SexoPessoa { get; set; }

        [Required, Display(Name = "Idade")]
        public int IdadePessoa { get; set; }
    }
}