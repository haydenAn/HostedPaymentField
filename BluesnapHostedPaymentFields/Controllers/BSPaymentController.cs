using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Encodings.Web;
using Newtonsoft.Json.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BluesnapHostedPaymentFields.Controllers
{
	public class BSPaymentController : Controller
	{
		//[Controller]/[ActionName]/[Parameters]
		//GET : /BSPayment/
		/*	public IActionResult Index(string name, int numTimes = 1)
			{
				ViewData["Message"] = "Hello " + name;
				ViewData["NumTimes"] = numTimes;

				return View();
			}*/
		//   /BSPayment/ccPayment
		public IActionResult Index()
		{
			//need to set up http get token here
			using (var httpClient = new HttpClient())
			{
				/*		using var request = new HttpRequestMessage(new HttpMethod("POST"), "https://sandbox.bluesnap.com/services/2/transactions");
						request.Headers.TryAddWithoutValidation("Accept", "application/json");
						request.Headers.TryAddWithoutValidation("Authorization", "Basic QVBJXzE2MTY1OTk2MjU3MzIxNzMzMDI1NDAzOktTIUc0UG8wZT98OmFpZHczL0lA");

						*/

				/*				string jsonStr = @"{
					'amount': 11,

					'softDescriptor': 'DescTest',
					'cardHolderInfo': {
									'firstName': 'Hyeryeon',
						'lastName': 'An', 
						'zip': '75028'

					},
					'currency': 'USD',
					'cardTransactionType': 'AUTH_CAPTURE',
					'pfToken':  'eyJhbGciOiJIUzI1NiJ9.eyJwYXlsb2FkIjp7ImNvbW1vbkp3dFBheWxvYWQiOnsiaWQiOiIxMjcyNDQ5Njc0OTIwNDkwMzUxMDYyMTgiLCJkYXRlQ3JlYXRlZCI6MTYyNzQ4Mjg1MTM5NH0sIm1lcmNoYW50SWQiOjkxMzIwOSwic2VudHJ5Ijp7Im1lcmNoYW50IjpmYWxzZSwiYXBwcyI6W119fX0.RkwPo9qbFm06ezWXjqLOnDFLD8z0HjLucM_MQdeRXZY._'
				}";

								var data = new StringContent(jsonStr, System.Text.Encoding.UTF8, "application/json");*/

				var testData = new
				{
					amount = 11,
					softDescriptor = "test description text",
					cardHolderInfo = new
					{
						firstName = "Hyeryeon",
						lastName = "An",
						zip = "75028"
					},
					currency = "USD",
					cardTransactionType = "AUTH_CAPTURE",
					pfToken = "eyJhbGciOiJIUzI1NiJ9.eyJwYXlsb2FkIjp7ImNvbW1vbkp3dFBheWxvYWQiOnsiaWQiOiIxMjcyODg3MjQ4Nzk4OTc0Mjc5NjM2NzAiLCJkYXRlQ3JlYXRlZCI6MTYyNzQ4NzIyNzEzMn0sIm1lcmNoYW50SWQiOjkxMzIwOSwic2VudHJ5Ijp7Im1lcmNoYW50IjpmYWxzZSwiYXBwcyI6W119fX0.q_LTPgzb6efs9LlRoVIxV10BC1N_WWl24RkzPakyPk4._"
				};

				var stringTestData = new StringContent(JsonConvert.SerializeObject(testData),
								  Encoding.UTF8, "application/json");


				string url = "https://sandbox.bluesnap.com/services/2/transactions";
				httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", "QVBJXzE2MTY1OTk2MjU3MzIxNzMzMDI1NDAzOktTIUc0UG8wZT98OmFpZHczL0lA");
				/*				httpClient.DefaultRequestHeaders.Add("Content-Type", "application/json");*//**/

				var response = httpClient.PostAsync(url, stringTestData);
				var result = response.Result;



				//ViewData["Res"] = result;
				ViewData["Res"] = @"{
					'cardTransactionType': 'AUTH_CAPTURE',
    'transactionId': '1048625397',
    'softDescriptor': 'BLS*DescTest',
    'descriptorPhoneNumber': '7132695565',
    'amount': 11.00,
    'usdAmount': 11.00,
    'currency': 'USD',
    'cardHolderInfo': {
						'firstName': 'Hyeryeon',
        'lastName': 'An',
        'zip': '75028'

	},
    'vaultedShopperId': 32359373,
    'creditCard': {
						'cardLastFourDigits': '8212',
        'cardType': 'MASTERCARD',
        'cardSubType': 'DEBIT',
        'cardCategory': 'ENHANCED',
        'binCategory': 'CONSUMER',
        'binNumber': '510805',
        'cardRegulated': 'N',
        'issuingBank': 'CAPITAL ONE BANK (USA), NATIONAL ASSOCIATION',
        'expirationMonth': '6',
        'expirationYear': '2025',
        'issuingCountryCode': 'us'

	},
    'processingInfo': {
						'processingStatus': 'success',
        'cvvResponseCode': 'ND',
        'authorizationCode': '654321',
        'avsResponseCodeZip': 'U',
        'avsResponseCodeAddress': 'U',
        'avsResponseCodeName': 'U'

	},
    'fraudResultInfo': { }
				}

			}";
				return View();
			}
		}
/*
		//https://localhost:44305/bspayment/welcome?name=Rick&numtimes=4

		public string welcome(string name, int numTimes = 1)
		{
			return HtmlEncoder.Default.Encode($"Hello {name} , Numtimes is {numTimes}");
		}*/



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
