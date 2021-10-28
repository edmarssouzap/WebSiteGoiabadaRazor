using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PaginaGoiabada.Data;
using PaginaGoiabada.Models;

namespace PaginaGoiabada.Pages.Clientes
{
    public class CreateModel : PageModel
    {
        private readonly PaginaGoiabada.Data.PaginaGoiabadaContext _context;

        public CreateModel(PaginaGoiabada.Data.PaginaGoiabadaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["EnderecoID"] = new SelectList(_context.Set<Endereco>(), "ID", "ID");
            return Page();
        }

        [BindProperty]
        public Cliente Cliente { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Cliente.Add(Cliente);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
