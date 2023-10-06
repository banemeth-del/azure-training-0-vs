using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using azure_training_0_vs.Data;

namespace azure_training_0_vs.Pages_Persons
{
    public class IndexModel : PageModel
    {
        private readonly azure_training_0_vs.Data.AppDBContext _context;

        public IndexModel(azure_training_0_vs.Data.AppDBContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Persons != null)
            {
                Person = await _context.Persons.ToListAsync();
            }
        }
    }
}
