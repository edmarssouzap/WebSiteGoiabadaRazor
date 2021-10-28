using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PaginaGoiabada.Models;

namespace PaginaGoiabada.Data
{
    public class PaginaGoiabadaContext : DbContext
    {
        public PaginaGoiabadaContext (DbContextOptions<PaginaGoiabadaContext> options)
            : base(options)
        {
        }

        // Método utilizado para acessar o banco de dados usando SQL Server e a string de conexao
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=192.168.15.9; Database=db_Goiabada; User ID=sa; Password=sql123;");
        }

        public DbSet<PaginaGoiabada.Models.Cliente> Cliente { get; set; }

        public DbSet<PaginaGoiabada.Models.Fornecedor> Fornecedor { get; set; }

        public DbSet<PaginaGoiabada.Models.Endereco> Endereco { get; set; }

        public DbSet<PaginaGoiabada.Models.Produto> Produto { get; set; }
    }
}
