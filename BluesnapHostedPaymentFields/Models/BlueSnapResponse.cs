using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BluesnapHostedPaymentFields.Models
{
	public class BlueSnapResponse
	{
		public string CardTransactionType { get; set; }

		public string TransactionId { get; set; }

		public string SoftDescriptor { get; set; }

		public double Amount { get; set; }

		public double UsdAmount { get; set; }

		public string Currency { get; set; }

		public DateTime TransactionApprovalDate { get; set; }

		public string TransactionApprovalTime { get; set; }

		public CardHolderInfo CardHolderInfo { get; set; }

		public int VaultedShopperId { get; set; }

		public CreditCard CreditCard { get; set; }

		public ProcessingInfo ProcessingInfo { get; set; }
	}

}