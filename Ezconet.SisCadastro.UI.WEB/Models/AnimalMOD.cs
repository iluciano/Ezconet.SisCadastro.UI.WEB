using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ezconet.SisCadastro.UI.WEB.Models
{
    public class AnimalMOD
    {
        [Key]
        public int CodAnimal { get; set; }
        [Required]
        public string NomeAnimal { get; set; }
        [Required]
        public byte SexoAnimal { get; set; }
        [Required]
        public int IdadeAnimal { get; set; }
    }
}