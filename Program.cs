Console.WriteLine("Bienvenido al sistema de reporte de fugas de agua");
WaterLeakReportCollector report =new WaterLeakReportCollector();
WaterLeakDataProcessor pros = new WaterLeakDataProcessor();
pros.ProcessData(report.CollectData());
