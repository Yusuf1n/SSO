﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SSO.Client.Controllers;

public class AuthenticationController : Controller
{
    [Authorize]
    public async Task Logout()
    {
        // Clears the local cookie
        await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

        await HttpContext.SignOutAsync(OpenIdConnectDefaults.AuthenticationScheme);
    }
}