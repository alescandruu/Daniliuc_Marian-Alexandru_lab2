using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Daniliuc_Marian_Alexandru_lab2.Data;
using Daniliuc_Marian_Alexandru_lab2.Models;

namespace Daniliuc_Marian_Alexandru_lab2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Daniliuc_Marian_Alexandru_lab2.Data.Daniliuc_Marian_Alexandru_lab2Context _context;

        public IndexModel(Daniliuc_Marian_Alexandru_lab2.Data.Daniliuc_Marian_Alexandru_lab2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Book != null)
            {
                Book = await _context.Book.ToListAsync();
            }
        }
    }
}
