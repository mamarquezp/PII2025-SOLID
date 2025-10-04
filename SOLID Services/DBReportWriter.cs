using PII2025_SOLID.SOLID_Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII2025_SOLID.SOLID_Services
{
    internal class DBReportWriter: IReportWriter
    {
        public void Write(string name, string content)
        {
            Console.WriteLine($"Conectando a: DB_Sim...");
            Console.WriteLine($"Insert de Reporte '{name}' en la DB_Sim");
            Console.WriteLine($"Contenido: {content}");
            Console.WriteLine($"Conección finalizada");
        }
    }
}
