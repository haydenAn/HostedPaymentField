using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BluesnapHostedPaymentFields.Models
{
	public class BlueSnapTransaction
	{
		public double amount { get; set; }

		public string softDescriptor { get; set; } = "BLS*DayStar Sandbox";

		public CardHolderInfo cardHolderInfo { get; set; }

		public string currency { get; set; } = "USD";

		public string cardTransactionType { get; set; } = "AUTH_CAPTURE";

		public string pfToken { get; set; }
	}	
}
