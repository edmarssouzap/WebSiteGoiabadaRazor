using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PaginaGoiabada.Models
{
    public class Produto
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Nome de produto")]
        public string Nome { get; set; }
        [Display(Name = "Preço")]
        public float Preco { get; set; }
        public int Quantidade { get; set; }

        [Display(Name = "Código do Fornecedor")]
        public int FornecedorID { get; set; }

        [ForeignKey("FornecedorID")]
        public virtual Fornecedor Fornecedor { get; set; }
    }
}
