using System;

public class WaterLeakReportCollector
{
    public WaterLeakReport CollectData()
    {
        Console.WriteLine("Localización de la fuga:");
        string location = Console.ReadLine();

        Console.WriteLine("Fecha del reporte (en formato dd/mm/yyyy):");
        string userInput;
        DateTime reportDate;
        do
        {
            userInput = Console.ReadLine();
            if (!DateTime.TryParseExact(userInput, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out reportDate))
            {
                Console.WriteLine("Error con la fecha, favor de verificarla (El formato debe ser dd/mm/aaaa).");
            }
        } while (!DateTime.TryParseExact(userInput, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out reportDate));

        Console.WriteLine("Ingrese el tiempo que tiene la fuga:");
        string vanishingtime = Console.ReadLine();

        Console.WriteLine("Nombre del reportador:");
        string reporterName = Console.ReadLine();

        Console.WriteLine("Descripción de la fuga:");
        string description = Console.ReadLine();

        Console.WriteLine("Localización georeferenciada:");
        string georeferencedLocation = Console.ReadLine();

        Console.WriteLine("Gravedad de la fuga (en una escala del 1 al 10):");
        string severityInput;
        int severity;
        do
        {
            severityInput = Console.ReadLine();
            if (!int.TryParse(severityInput, out severity) || severity < 1 || severity > 10)
            {
                Console.WriteLine("Error con la gravedad de la fuga, favor de verificarla.");
            }
        } while (!int.TryParse(severityInput, out severity) || severity < 1 || severity > 10);

        Console.WriteLine("Hora del reporte (en formato hh:mm:ss):");
        string reportTimeInput;
        TimeSpan reportTime;
        do
        {
            reportTimeInput = Console.ReadLine();
            if (!TimeSpan.TryParse(reportTimeInput, out reportTime))
            {
                Console.WriteLine("Error con la hora del reporte, favor de verificarla.");
            }
        } while (!TimeSpan.TryParse(reportTimeInput, out reportTime));

        Console.WriteLine("Número de teléfono de contacto:");
        string phoneNumber = Console.ReadLine();

        Console.WriteLine("Correo electrónico de contacto:");
        string email;
        do
        {
            email = Console.ReadLine();
            if (!email.Contains("@"))
            {
                Console.WriteLine("Error con el correo electrónico, favor de verificarlo.");
            }
        } while (!email.Contains("@"));

        Console.WriteLine("Edad del reportador:");
        string ageInput;
        int age;
        do
        {
            ageInput = Console.ReadLine();
            if (!int.TryParse(ageInput, out age))
            {
                Console.WriteLine("Error con la edad del reportador, favor de verificarla.");
            }
        } while (!int.TryParse(ageInput, out age));

        var WaterLeakReport = new WaterLeakReport
        {
            Location = location,
            ReportDate = reportDate,
            vanishingtime = vanishingtime,
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
    public string vanishingtime { get; set; }
    public string ReporterName { get; set; }
    public string Description { get; set; }
    public string GeoreferencedLocation { get; set; }
    public int Severity { get; set; }
    public TimeSpan ReportTime { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public int Age { get; set; }
}
