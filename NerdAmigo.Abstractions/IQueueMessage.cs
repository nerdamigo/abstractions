﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdAmigo.Abstractions
{
	public interface IQueueMessage
	{
		QueueMessageIdentifier MessageId { get; set; }
	}
}
