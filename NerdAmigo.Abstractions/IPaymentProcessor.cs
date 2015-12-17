using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdAmigo.Abstractions
{
	public interface IPaymentProcessor<TPaymentMethod> where TPaymentMethod : IPaymentMethod
	{
		PaymentTransactionType SupportedTransactionTypes { get; }
	}
}
