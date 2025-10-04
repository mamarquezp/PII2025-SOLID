using PII2025_SOLID.SOLID_Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII2025_SOLID.SOLID_Services
{
	internal class PlainTextFormatter : IReportFormatter
	{
		public string FormatReport(DateTime day, decimal totalSales)
		{
			return $"Reporte de ventas {day:yyyy-MM-dd}\nTotal: {totalSales:C}";
		}
	}
}
