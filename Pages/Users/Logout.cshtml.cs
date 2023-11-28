using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace bad_admin.Pages;

[IgnoreAntiforgeryToken]
public class LogoutModel : PageModel
{

    private ILogger<LoginModel> _logger;

    public LogoutModel(ILogger<LoginModel> logger)
    {
        this._logger = logger;
    }

    public IActionResult OnGet()
    {
        Response.Cookies.Delete("Username");
        return RedirectToPage("/");

    }

    

}