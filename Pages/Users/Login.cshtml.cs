using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace bad_admin.Pages;

[IgnoreAntiforgeryToken]
public class LoginModel : PageModel
{

    private ILogger<LoginModel> _logger;
    private IUsersRepository _userRepository;

    public LoginModel(ILogger<LoginModel> logger, IUsersRepository usersRepository)
    {
        this._logger = logger;
        this._userRepository = usersRepository;
    }

    public void OnGet()
    {

        if (TempData["Message"] != null)
        {
            ViewData["Message"] = TempData["Message"];
        }
        
        _logger.LogInformation("Get - Login");
    }

    public async Task<IActionResult> OnPost(string username, string password)
    {
        if (string.IsNullOrEmpty(username))
        {
            TempData["Message"] = "Username or password is empty.";
            return RedirectToAction("OnGet");

        }


        _logger.LogInformation("Post - Login {username}/{password}", username, password);
        var user = await _userRepository.GetUserByUsernameAndPassword(username, password);

        if (user != null)
        {
            Response.Cookies.Append("Username", user.Username);
            return RedirectToPage("/Products/List");
        }
        TempData["Message"] = "Login failed.";
        return RedirectToAction("OnGet");
    }

}