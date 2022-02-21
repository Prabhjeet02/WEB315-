using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesComputer.Models;

namespace RazorPagesComputer.Pages_Computers
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesComputerContext _context;

        public CreateModel(RazorPagesComputerContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Computer Computer { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Computer.Add(Computer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
