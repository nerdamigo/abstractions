﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdAmigo.Abstractions
{
	public interface IPaymentTransactionResult
	{
		PaymentTransactionType TransactionType { get; }
		bool IsSuccessful { get; }
		DateTime TransactionTimestamp { get; }
	}
}
