using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SchoolCoreAppRazor.Models;

namespace SchoolCoreAppRazor.Pages.Enrollments
{
    public class IndexModel : PageModel
    {
        private readonly SchoolCoreAppRazor.Models.SchoolContext _context;

        public IndexModel(SchoolCoreAppRazor.Models.SchoolContext context)
        {
            _context = context;
        }

        public IList<Enrollment> Enrollment { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Enrollment = await _context.Enrollments.ToListAsync();
        }
    }
}
