using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CI_CD.Pages;

public class EvilPlan : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    public EvilPlan(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

