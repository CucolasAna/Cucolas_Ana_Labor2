﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly Cucolas_Ana_Labor2.Data.Cucolas_Ana_Labor2Context _context;

        public DetailsModel(Cucolas_Ana_Labor2.Data.Cucolas_Ana_Labor2Context context)
        {
            _context = context;
        }

      public Book Book { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Book == null)
            {
                return NotFound();
            }

            var book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);
            if (book == null)
            {
                return NotFound();
            }
            else 
            {
                Book = book;
            }
            return Page();
        }
    }
}
