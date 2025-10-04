using PII2025_SOLID.SOLID_Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace PII2025_SOLID.SOLID_Services
{
	internal class SalesReportCoordinator
	{
		private readonly ISalesCalculator calculator;
		private readonly IReportFormatter formatter;
		private readonly IReportWriter writer;
		private readonly IReportSender sender;


		public SalesReportCoordinator(ISalesCalculator c, IReportFormatter f, IReportWriter w, IReportSender s)
		{
			calculator = c;
			formatter = f; 
			writer = w; 
			sender = s;
		}

		public void GenerateAndSend(DateTime day) {

			var total = calculator.GetTotalSales(day);
			var content = formatter.FormatReport(day, total);
			writer.Write(day.ToString("yyyyMMdd"), content);
			sender.Send("noreply@miempresa.com", "gerencia@miempresa.com", "Reporte de ventas", content);
		}
	}
}
