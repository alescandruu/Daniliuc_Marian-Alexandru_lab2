using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Daniliuc_Marian_Alexandru_lab2.Data;
using Daniliuc_Marian_Alexandru_lab2.Models;

namespace Daniliuc_Marian_Alexandru_lab2.Pages.Publishers
{
    public class DetailsModel : PageModel
    {
        private readonly Daniliuc_Marian_Alexandru_lab2.Data.Daniliuc_Marian_Alexandru_lab2Context _context;

        public DetailsModel(Daniliuc_Marian_Alexandru_lab2.Data.Daniliuc_Marian_Alexandru_lab2Context context)
        {
            _context = context;
        }

      public Book Book { get; set; }

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
