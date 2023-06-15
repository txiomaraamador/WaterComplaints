using System;
using System.Text.RegularExpressions;

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
        string georeferencedLocation;
        do
        {
            georeferencedLocation = Console.ReadLine();
            if (!georeferencedLocation.Contains(","))
            {
                Console.WriteLine("Error con la Localización, favor de verificarla.");
            }
        } while (!georeferencedLocation.Contains(","));

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

        DateTime reportTime = DateTime.Now;


        string phoneNumber;
        string patternphone = @"^\d{10}$";
        do
        {
            Console.WriteLine("Número de teléfono de contacto (de 10 digitos): ");
            phoneNumber = Console.ReadLine();

            if (!Regex.IsMatch(phoneNumber, patternphone))
            {
                Console.WriteLine("El numero de telefono es invalido. Vuelva a ingresarlo: ");
            }

        } while (!Regex.IsMatch(phoneNumber, patternphone));


        string email;
        string patternemail = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        do
        {
            Console.WriteLine("Correo electronico de contacto: ");
            email = Console.ReadLine();

            if (!Regex.IsMatch(email, patternemail))
            {
                Console.WriteLine("El correo electrónico ingresado es inválido. Vuelva a ingresarlo.");
            }
        } while (!Regex.IsMatch(email, patternemail));


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