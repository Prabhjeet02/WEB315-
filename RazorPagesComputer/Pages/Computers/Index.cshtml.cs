using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesComputer.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RazorPagesComputer.Pages_Computers
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesComputerContext _context;

        public IndexModel(RazorPagesComputerContext context)
        {
            _context = context;
        }

        public IList<Computer> Computer { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList ProcessorList { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Processor { get; set; }
        public async Task OnGetAsync()
        {
             IQueryable<string> ProcessorQuery = from c in _context.Computer
                                              orderby c.Processor
                                              select c.Processor;
    var Computers = from c in _context.Computer
                 select c;//  SELECT from computer
    if (!string.IsNullOrEmpty(SearchString))
    {
        Computers = Computers.Where(c => c.Company.ToLower().Contains(SearchString.ToLower()));
     }

            if (!string.IsNullOrEmpty(Processor))
            {
                Computers = Computers.Where(c => c.Processor == Processor);
            }
            ProcessorList = new SelectList(await ProcessorQuery.Distinct().ToListAsync());

            Computer = await Computers.ToListAsync();
        }
    }
}
