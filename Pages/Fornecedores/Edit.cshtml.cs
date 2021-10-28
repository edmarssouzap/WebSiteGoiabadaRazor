﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PaginaGoiabada.Data;
using PaginaGoiabada.Models;

namespace PaginaGoiabada.Pages.Fornecedores
{
    public class EditModel : PageModel
    {
        private readonly PaginaGoiabada.Data.PaginaGoiabadaContext _context;

        public EditModel(PaginaGoiabada.Data.PaginaGoiabadaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Fornecedor Fornecedor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Fornecedor = await _context.Fornecedor
                .Include(f => f.Endereco).FirstOrDefaultAsync(m => m.ID == id);

            if (Fornecedor == null)
            {
                return NotFound();
            }
           ViewData["EnderecoID"] = new SelectList(_context.Endereco, "ID", "ID");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Fornecedor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FornecedorExists(Fornecedor.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool FornecedorExists(int id)
        {
            return _context.Fornecedor.Any(e => e.ID == id);
        }
    }
}
