using PII2025_SOLID.SOLID_Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII2025_SOLID.SOLID_Services
{
	internal class FileReportWriter: IReportWriter
	{
		public void Write(string name, string content) {
			string tempBase = Path.GetTempPath();
			string tempReportes = Path.Combine(tempBase, "reportes");
			Directory.CreateDirectory(tempReportes);

			var path = Path.Combine(tempReportes, name);
			System.IO.File.WriteAllText(path, content);

			Console.WriteLine(path);
		}
	}
}
