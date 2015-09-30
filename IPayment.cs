using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdAmigo.Abstractions
{
	public interface IPayment
	{
		IPaymentMethod PaymentMethod { get; }
		decimal AuthorizedAmount { get; }
		decimal CapturedAmount { get; }
	}
}
