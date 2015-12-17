using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdAmigo.Abstractions
{
	[Flags]
	public enum PaymentTransactionType
	{
		Authorization = 1,

		Capture = 2,
		PriorAuthorizationCapture = 2,

		Sale = 4,
		AuthorizationAndCapture = 4,

		Void = 8,

		Refund = 16,
		Credit = 16
	}
}
