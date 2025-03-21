using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
   
    private IHttpClientFactory _clientFactory { get; }

    public HomeController(ILogger<HomeController> logger, IHttpClientFactory clientFactory)
    {
        _logger = logger;
        _clientFactory = clientFactory;
    }
    
    public async Task<IActionResult> Index()
    {
      return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
              // This line returns a view for the Error action method, passing an instance of the ErrorViewModel.
        // The ErrorViewModel is initialized with the RequestId property, which is set to the current activity ID if available,
        // or the HTTP context trace identifier if the activity ID is not available.
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    
    }
}
