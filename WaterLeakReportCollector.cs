using System;

public class WaterLeakReportCollector
{
    public WaterLeakReport CollectData()
    {
        Console.WriteLine("Localización de la fuga:");
        string location = Console.ReadLine();

        Console.WriteLine("Fecha del reporte (en formato dd/mm/yyyy):");
        string userInput = Console.ReadLine();
        if (!DateTime.TryParseExact(userInput, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime reportDate))
        {
            Console.WriteLine("Error con la fecha, favor de verificarla (El formato debe ser dd/mm/aaaa).");
            return null;
        }

        Console.WriteLine("Ingrese el tiempo que tiene la fuga: (en formato hh:mm:ss)");
        if (!TimeSpan.TryParse(Console.ReadLine(), out TimeSpan leakTime))
        {
            Console.WriteLine("Error con el tiempo de la fuga, favor de verificarlo (El formato debe ser hh:mm:ss).");
            return null;
        }

        Console.WriteLine("Nombre del reportador:");
        string reporterName = Console.ReadLine();

        Console.WriteLine("Descripción de la fuga:");
        string description = Console.ReadLine();

        Console.WriteLine("Localización georeferenciada:");
        string georeferencedLocation = Console.ReadLine();

        Console.WriteLine("Gravedad de la fuga (en una escala del 1 al 10):");
        if (!int.TryParse(Console.ReadLine(), out int severity))
        {
            Console.WriteLine("Error con la gravedad de la fuga, favor de verificarla.");
            return null;
        }

        Console.WriteLine("Hora del reporte (en formato hh:mm:ss):");
        if (!TimeSpan.TryParse(Console.ReadLine(), out TimeSpan reportTime))
        {
            Console.WriteLine("Error con la hora del reporte, favor de verificarla.");
            return null;
        }

        Console.WriteLine("Número de teléfono de contacto:");
        string phoneNumber = Console.ReadLine();

        Console.WriteLine("Correo electrónico de contacto:");
        string email = Console.ReadLine();

        Console.WriteLine("Edad del reportador:");
        if (!int.TryParse(Console.ReadLine(), out int age))
        {
            Console.WriteLine("Error con la edad del reportador, favor de verificarla.");
            return null;
        }

        var WaterLeakReport = new WaterLeakReport
        {
            Location = location,
            ReportDate = reportDate,
            LeakTime = leakTime,
            ReporterName = reporterName,
            Description = description,
            GeoreferencedLocation = georeferencedLocation,
            Severity = severity,
            ReportTime = reportTime,
            PhoneNumber = phoneNumber,
            Email = email,
            Age = age
        };

        return WaterLeakReport;
    }
}

public class WaterLeakReport
{
    public string Location { get; set; }
    public DateTime ReportDate { get; set; }
    public TimeSpan LeakTime { get; set; }
    public string ReporterName { get; set; }
    public string Description { get; set; }
    public string GeoreferencedLocation { get; set; }
    public int Severity { get; set; }
    public TimeSpan ReportTime { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public int Age { get; set; }
}
