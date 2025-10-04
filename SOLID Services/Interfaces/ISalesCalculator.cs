using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII2025_SOLID.SOLID_Services.Interfaces
{
	internal interface ISalesCalculator
	{
		decimal GetTotalSales(DateTime day);
	}
}
