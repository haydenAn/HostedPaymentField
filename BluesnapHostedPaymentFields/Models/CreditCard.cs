using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BluesnapHostedPaymentFields.Models
{
	public class CreditCard {
			public string CardLastFourDigits { get; set; }

	public string CardType { get; set; }

	public string CardSubType { get; set; }

	public string BinCategory { get; set; }

	public string BinNumber { get; set; }

	public string CardRegulated { get; set; }

	public string IssuingBank { get; set; }

	public string ExpirationMonth { get; set; }

	public string ExpirationYear { get; set; }

	public string IssuingCountryCode { get; set; }
	}
}
