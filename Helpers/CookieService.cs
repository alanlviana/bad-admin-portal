
using Microsoft.Extensions.Caching.Distributed;

namespace bad_admin.Helpers;


public class CookieService
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public CookieService(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public bool IsCookiePresent(string cookieName)
    {
        
        var cookieValue = _httpContextAccessor.HttpContext.Request.Cookies[cookieName];
        return !string.IsNullOrEmpty(cookieValue);
    }

    public string GetCookieValue(string cookieName)
    {
        return _httpContextAccessor.HttpContext.Request.Cookies[cookieName];
    }
}