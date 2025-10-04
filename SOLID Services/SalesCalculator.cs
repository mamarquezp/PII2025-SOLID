
using PII2025_SOLID.SOLID_Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII2025_SOLID.SOLID_Services
{
	internal class SalesCalculator: ISalesCalculator
	{
		public decimal GetTotalSales(DateTime day) => 1250.50m; // simulado
	}
}
