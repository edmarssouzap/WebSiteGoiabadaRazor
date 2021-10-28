using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PaginaGoiabada.Data;
using PaginaGoiabada.Models;

namespace PaginaGoiabada.Pages.Fornecedores
{
    public class IndexModel : PageModel
    {
        private readonly PaginaGoiabada.Data.PaginaGoiabadaContext _context;

        public IndexModel(PaginaGoiabada.Data.PaginaGoiabadaContext context)
        {
            _context = context;
        }

        public IList<Fornecedor> Fornecedor { get;set; }

        public async Task OnGetAsync()
        {
            Fornecedor = await _context.Fornecedor
                .Include(f => f.Endereco).ToListAsync();
        }
    }
}
