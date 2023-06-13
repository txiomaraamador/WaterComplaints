Console.WriteLine("Bienvenido al sistema de reporte de fugas de agua");
ConsultaDeDatos cons=new ConsultaDeDatos();
cons.ConsultarNombre();
WaterLeakReportCollector report =new WaterLeakReportCollector();
WaterLeakDataProcessor pros = new WaterLeakDataProcessor();
pros.ProcessData(report.CollectData());
