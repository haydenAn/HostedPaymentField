using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BluesnapHostedPaymentFields.Models
{
	public class ProcessingInfo
	{

		public string ProcessingStatus { get; set; }

		public string CvvResponseCode { get; set; }

		public string AuthorizationCode { get; set; }

		public string AvsResponseCodeZip { get; set; }

		public string AvsResponseCodeAddress { get; set; }

		public string AvsResponseCodeName { get; set; }
	}
}
