using PII2025_SOLID.Services;
using PII2025_SOLID.SOLID_Services;

//SalesReportService salesReportService = new SalesReportService();


EmailReportSender emailReportSender = new EmailReportSender();
SalesCalculator salesCalculator = new SalesCalculator();
PlainTextFormatter plainTextFormatter = new PlainTextFormatter();
FileReportWriter fileReportWriter = new FileReportWriter();

SalesReportCoordinator salesReportCoordinator = new SalesReportCoordinator(salesCalculator, plainTextFormatter, fileReportWriter, emailReportSender);

//salesReportService.GenerateAndSendReport(DateTime.Now);

salesReportCoordinator.GenerateAndSend(DateTime.Now);
