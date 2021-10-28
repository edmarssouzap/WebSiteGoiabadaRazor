using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PaginaGoiabada.Data;
using PaginaGoiabada.Models;

namespace PaginaGoiabada.Pages.Produtos
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
        ViewData["FornecedorID"] = new SelectList(_context.Fornecedor, "ID", "ID");
            return Page();
        }

        [BindProperty]
        public Produto Produto { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Produto.Add(Produto);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
