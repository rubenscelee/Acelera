using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Aula_02.NetFramework.Models
{
    public class Alunos
    {
        [Display(Name = "Código do Cliente")]
        public int ID { get; set; }
        [Required]
        [StringLength(20)]
        public string Nome { get; set; }

        public string CPF { get; set; }
    }
}