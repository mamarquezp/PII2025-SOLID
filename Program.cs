using PII2025_SOLID.Services;
using PII2025_SOLID.SOLID_Services;

//SalesReportService salesReportService = new SalesReportService();

WAReportSender whatsappSender = new WAReportSender();
DBReportWriter databaseWriter = new DBReportWriter();
//EmailReportSender emailReportSender = new EmailReportSender();
SalesCalculator salesCalculator = new SalesCalculator();
PlainTextFormatter plainTextFormatter = new PlainTextFormatter();
//FileReportWriter fileReportWriter = new FileReportWriter();

SalesReportCoordinator salesReportCoordinator = new SalesReportCoordinator(salesCalculator, plainTextFormatter, databaseWriter, whatsappSender);

//salesReportService.GenerateAndSendReport(DateTime.Now);

salesReportCoordinator.GenerateAndSend(DateTime.Now);
