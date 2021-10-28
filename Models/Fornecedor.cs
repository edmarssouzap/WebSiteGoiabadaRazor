using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PaginaGoiabada.Models
{
    public class Fornecedor
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Nome do Fornecedor")]
        public string Nome { get; set; }
        [Display(Name = "CPNJ")]
        public string Cnpj { get; set; }

        [Display(Name = "Código de Endereço")]
        public int EnderecoID { get; set; }
        
        [ForeignKey("EnderecoID")]
        public virtual Endereco Endereco { get; set; }
    }
}
