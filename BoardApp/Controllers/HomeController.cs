// Programmer name : BoardApp Group
// Student nr      : 222049725;223022994;225007032;220024412;225004492
// Assignment nr   : Practical Assessment 1
// Purpose         : Controller responsible for the home page, privacy
//                  page, and generic error handling

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BoardApp.Models;

namespace BoardApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            //
            //Name              : HomeController(ILogger<HomeController> logger)
            //Purpose           : Constructor that stores the injected
            //                  logger for later use
            //Re-use            : None
            //Method Parameters : ILogger<HomeController> logger
            //                  - the logger instance supplied by
            //                  dependency injection
            //Output Type       : None
            //
            _logger = logger;
        } // end method

        public IActionResult Index()
        {
            //
            //Name              : IActionResult Index()
            //Purpose           : Returns the default home page view
            //Re-use            : None
            //Method Parameters : None
            //Output Type       : IActionResult
            //                  - the Index view
            //
            return View();
        } // end method

        public IActionResult Privacy()
        {
            //
            //Name              : IActionResult Privacy()
            //Purpose           : Returns the default Privacy page view
            //Re-use            : None
            //Method Parameters : None
            //Output Type       : IActionResult
            //                  - the Privacy view
            //
            return View();
        } // end method

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            //
            //Name              : IActionResult Error()
            //Purpose           : Returns the default Error view,
            //                  populated with the current request's
            //                  identifier for diagnostic purposes
            //Re-use            : None
            //Method Parameters : None
            //Output Type       : IActionResult
            //                  - the Error view, populated with an
            //                  ErrorViewModel
            //
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        } // end method
    } // end class HomeController
} // end namespace BoardApp.Controllers