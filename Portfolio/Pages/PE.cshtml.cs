using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Portfolio.Pages
{
    public class PEModel : PageModel
    {
        private readonly ILogger<PEModel> _logger;

        public PEModel(ILogger<PEModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }

}
