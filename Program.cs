
Console.WriteLine("Bienvenido al sistema de reporte de fugas de agua");
        
Console.WriteLine("Seleccione una opción:");
Console.WriteLine("1. Consultar datos");
Console.WriteLine("2. Recolectar datos de fugas de agua");

string opcion = Console.ReadLine();

if (opcion == "1")
{
    ConsultaDeDatos consulta = new ConsultaDeDatos();
    consulta.ConsultarCorreo();
}
else if (opcion == "2")
{
    WaterLeakReportCollector report =new WaterLeakReportCollector();
    WaterLeakDataProcessor pros = new WaterLeakDataProcessor();
    pros.ProcessData(report.CollectData());
}
else
{
    Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
}


