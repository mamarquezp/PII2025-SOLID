using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII2025_SOLID.Services
{
	internal class SalesReportService
	{
		public void GenerateAndSendReport(DateTime day)
		{
			// 1) Cálculo
			var total = GetTotalSales(day);

			// 2) Formato
			var content = $"Reporte de ventas {day:yyyy-MM-dd}\nTotal: {total:C}";

			// 3) Persistencia (I/O)
			string tempBase = Path.GetTempPath();
			string tempReportes = Path.Combine(tempBase, "reportes");
			Directory.CreateDirectory(tempReportes);

			var path = Path.Combine(tempReportes, $"{day:yyyyMMdd}.txt");
			System.IO.File.WriteAllText(path, content);

			Console.WriteLine(path);

			// 4) Envío (infraestructura)
			SendEmail("noreply@miempresa.com", "gerencia@miempresa.com", "Reporte de ventas", content);
		}

		private decimal GetTotalSales(DateTime day) {
			return 1250.50m; // simulado
		}

		private void SendEmail(string from, string recipient, string subject, string body)  {
			Console.WriteLine($"Se envío un correo  con el reporte {from}->{recipient}");
			Console.WriteLine(subject);
			Console.WriteLine(body);
		}
	}
}
