using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII2025_SOLID.SOLID_Services.Interfaces
{
	internal interface IReportSender
	{
		void Send(string from, string recipient, string subject, string body);
	}
}
