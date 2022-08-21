using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp003.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly WebApp003DbContext _context;

        public IndexModel(ILogger<IndexModel> logger, WebApp003DbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public List<User> MyUsers { get; set; }

        public void OnGet()
        {
            MyUsers = _context.Users.ToList();            
        }
    }
}