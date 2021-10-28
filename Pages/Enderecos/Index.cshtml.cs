using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PaginaGoiabada.Data;
using PaginaGoiabada.Models;

namespace PaginaGoiabada.Pages.Enderecos
{
    public class IndexModel : PageModel
    {
        private readonly PaginaGoiabada.Data.PaginaGoiabadaContext _context;

        public IndexModel(PaginaGoiabada.Data.PaginaGoiabadaContext context)
        {
            _context = context;
        }

        public IList<Endereco> Endereco { get;set; }

        public async Task OnGetAsync()
        {
            Endereco = await _context.Endereco.ToListAsync();
        }
    }
}
