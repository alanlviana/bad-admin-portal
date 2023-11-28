using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace bad_admin.Pages;

public class ListModel : PageModel
{

    private readonly ILogger<ListModel> _logger;
    private readonly IProductsRepository _productsRepository;

    public ListModel(ILogger<ListModel> logger, IProductsRepository productsRepository)
    {
        _logger = logger;
        _productsRepository = productsRepository;
    }

    public async Task<IActionResult> OnGet(string productName)
    {
        string username;
        if (!Request.Cookies.TryGetValue("Username", out username)){
            return RedirectToPage("/Users/Login");
        }else if(string.IsNullOrEmpty(username)){
            return RedirectToPage("/Users/Login");
        }

        _logger.LogInformation("Searching for {productName}", productName);
        ViewData["ProductName"] = productName;
        var products = await _productsRepository.SearchProducts(productName);
        ViewData["Products"] = products;
        return Page();
    }
}

