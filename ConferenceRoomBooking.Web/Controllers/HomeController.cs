using ConferenceRoomBooking.Web.Models;
using DataAL.ViewModels;
using HGO.ASPNetCore.FileManager.CommandsProcessor;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace ConferenceRoomBooking.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IFileManagerCommandsProcessor _processor;

        public HomeController(ILogger<HomeController> logger, IFileManagerCommandsProcessor processor)
        {
            _processor = processor;
            _logger = logger;
        }

        [HttpPost, HttpGet]
        public async Task<IActionResult> HgoApi(string id, string command, string parameters, IFormFile file)
        {
            return await _processor.ProcessCommandAsync(id, command, parameters, file);
        }
        public IActionResult FileManager()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BookingSystem()
        {
            return View();
        }
        public IActionResult DocumentMS()
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
            var exceptionHandlerPathFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();

            return View(new CustomErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier,
                Exception = exceptionHandlerPathFeature?.Error // Pass the exception object
            });
        }

    }
}
