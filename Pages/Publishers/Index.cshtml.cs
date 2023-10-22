using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cucolas_Ana_Labor2.Data;
using Cucolas_Ana_Labor2.Models;

namespace Cucolas_Ana_Labor2.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Cucolas_Ana_Labor2.Data.Cucolas_Ana_Labor2Context _context;

        public IndexModel(Cucolas_Ana_Labor2.Data.Cucolas_Ana_Labor2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Publisher != null)
            {
                Publisher = await _context.Publisher.ToListAsync();
            }
        }
    }
}
