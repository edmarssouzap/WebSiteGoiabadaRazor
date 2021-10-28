using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PaginaGoiabada.Models
{
    public class Endereco
    {
        [Key]
        public int ID { get; set; }
        public string Rua { get; set; }
        [Display(Name = "Número")]
        public int Numero { get; set; }
        [Display(Name = "CEP")]
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}
