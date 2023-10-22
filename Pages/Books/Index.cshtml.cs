using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cucolas_Ana_Labor2.Data;
using Cucolas_Ana_Labor2.Models;

namespace Cucolas_Ana_Labor2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Cucolas_Ana_Labor2.Data.Cucolas_Ana_Labor2Context _context;

        public IndexModel(Cucolas_Ana_Labor2.Data.Cucolas_Ana_Labor2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Book = await _context.Book
            .Include(b => b.Publisher)
            .ToListAsync();
        }
    }
}
