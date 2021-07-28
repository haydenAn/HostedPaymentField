using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;


namespace BluesnapHostedPaymentFields.Controllers
{
	public class BSPaymentController : Controller
	{
		//[Controller]/[ActionName]/[Parameters]
		//GET : /BSPayment/
		public IActionResult Index(string name, int numTimes = 1)
		{
			ViewData["Message"] = "Hello " + name;
			ViewData["NumTimes"] = numTimes;

			return View();
		}

		//https://localhost:44305/bspayment/welcome?name=Rick&numtimes=4

		public string welcome(string name, int numTimes = 1)
		{
			return HtmlEncoder.Default.Encode($"Hello {name} , Numtimes is {numTimes}");
		}

		// GET: Movies/Details/5
/*		public async Task<IActionResult> Details(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var movie = await _context.Movie
				.FirstOrDefaultAsync(m => m.Id == id);
			if (movie == null)
			{
				return NotFound();
			}

			return View(movie);
			// goes to view with the passing model
			//@model bluesnapHostedPaymentFields.Models.modelName
			//@Html.DisplayNameFor(model => model.Title)

		}*/
	}
}
