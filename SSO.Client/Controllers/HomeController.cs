using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using SSO.Client.Models;
using System.Diagnostics;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Newtonsoft.Json;

namespace SSO.Client.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            await LogIdentityInformation();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> Weather()
        {
            using var client = new HttpClient();

            var result = await client
                .GetAsync("https://localhost:7150/weatherforecast");

            if (result.IsSuccessStatusCode)
            {
                var model = await result.Content.ReadAsStringAsync();

                var data = JsonConvert.DeserializeObject<List<WeatherData>>(model);

                return View(data);
            }

            throw new Exception("Unable to get content");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task LogIdentityInformation()
        {
            // get the saved identity token
            var identityToken = await HttpContext
                .GetTokenAsync(OpenIdConnectParameterNames.IdToken);

            var userClaimsStringBuilder = new StringBuilder();
            foreach (var claim in User.Claims)
            {
                userClaimsStringBuilder.AppendLine(
                    $"Claim type: {claim.Type} - Claim value: {claim.Value}");
            }

            // log token & claims
            _logger.LogInformation($"Identity token & user claims: " +
                                   $"\n{identityToken} \n{userClaimsStringBuilder}");
        }
    }
}