using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SSO.ClientBlazor.Pages;

public class AccessDeniedModel : PageModel
{
    public IActionResult OnGet()
    {
        return SignOut("Cookies", "OpenIdConnect");
    }
}