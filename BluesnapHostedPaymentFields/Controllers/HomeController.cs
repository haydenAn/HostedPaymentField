using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BluesnapHostedPaymentFields.Models;
using System.Net.Http;
using System.Net.Http.Headers;

namespace BluesnapHostedPaymentFields.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}
		//GET : /

		public IActionResult Index()
		{
			//need to set up http get token here
			string token = "";
			using (var httpClient = new HttpClient())
			{
				using var request = new HttpRequestMessage(new HttpMethod("POST"), "https://sandbox.bluesnap.com/services/2/payment-fields-tokens");
				request.Headers.TryAddWithoutValidation("Accept", "application/json");
				request.Headers.TryAddWithoutValidation("Authorization", "Basic QVBJXzE2MTY1OTk2MjU3MzIxNzMzMDI1NDAzOktTIUc0UG8wZT98OmFpZHczL0lA");

				request.Content = new StringContent("");
				request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

				var response = httpClient.SendAsync(request);
				var result = response.Result;
				token = result.Headers.Location.ToString();
			}

			ViewData["Token"] = token.Replace("https://sandbox.bluesnap.com/services/2/payment-fields-tokens/", "");

			return View();
		}


        public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
