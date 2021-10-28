using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PaginaGoiabada.Models
{
    public class Cliente
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Nome do Cliente")]
        public string Nome { get; set; }
        public string Telefone { get; set; }

        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Display(Name = "Código de Endereço")]
        public int EnderecoID { get; set; }

        [ForeignKey("EnderecoID")]
        public virtual Endereco Endereco { get; set; }
    }
}
