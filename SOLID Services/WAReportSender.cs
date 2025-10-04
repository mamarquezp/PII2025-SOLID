using PII2025_SOLID.SOLID_Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII2025_SOLID.SOLID_Services
{
    internal class WAReportSender : IReportSender
    {
        public void Send(string from, string recipient, string subject, string body)
        {
            Console.WriteLine($"Se envío un mensaje de WhatsApp con el reporte a {recipient}");
            Console.WriteLine(body);
        }
    }
}
