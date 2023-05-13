using Newtonsoft.Json;
using System.IO;

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


    public void CollectData(){

        Console.WriteLine("Por favor ingrese la localización de la fuga:");
        string location = Console.ReadLine();

        Console.WriteLine("Por favor ingrese la fecha del reporte (en formato dd/mm/yyyy):");
        DateTime reportDate = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Por favor ingrese el tiempo que tiene la fuga (en formato hh:mm:ss):");
        TimeSpan leakTime = TimeSpan.Parse(Console.ReadLine());

        Console.WriteLine("Por favor ingrese el nombre del reportador:");
        string reporterName = Console.ReadLine();

        Console.WriteLine("Por favor ingrese la descripción de la fuga:");
        string description = Console.ReadLine();

        Console.WriteLine("Por favor ingrese la localización georeferenciada:");
        string georeferencedLocation = Console.ReadLine();

        Console.WriteLine("Por favor ingrese la gravedad de la fuga (en una escala del 1 al 10):");
        int severity = int.Parse(Console.ReadLine());

        Console.WriteLine("Por favor ingrese la hora del reporte (en formato hh:mm:ss):");
        TimeSpan reportTime = TimeSpan.Parse(Console.ReadLine());

        Console.WriteLine("Por favor ingrese el número de teléfono de contacto:");
        string phoneNumber = Console.ReadLine();

        Console.WriteLine("Por favor ingrese el correo electrónico de contacto:");
        string email = Console.ReadLine();

        Console.WriteLine("Por favor ingrese la edad del reportador:");
        int age = int.Parse(Console.ReadLine());

        var datos = new
        {
            location = location,
            reportDate = reportDate,
            leakTime = leakTime,
            reporterName = reporterName,
            description = description,
            georeferencedLocation = georeferencedLocation,
            severity = severity,
            phoneNumber = phoneNumber,
            email = email,
            age = age
        };

        // Serializar el objeto a formato JSON
        string jsonData = JsonConvert.SerializeObject(datos, Formatting.Indented);

        Console.WriteLine("Datos en formato JSON:");
        Console.WriteLine(jsonData);

        // Llamar al método para guardar el JSON
        GuardarJson(jsonData);
    }
    public static void GuardarJson(string jsonData)
    {
        try
        {
            // Obtener el directorio actual
            string currentDirectory = Directory.GetCurrentDirectory();

            // Crear un nuevo archivo de texto
            string filePath = Path.Combine(currentDirectory, "datos.json");

            // Guardar el JSON en el archivo
            File.AppendAllText(filePath, jsonData + Environment.NewLine);

            Console.WriteLine("Los datos se han guardado correctamente en el archivo datos.json.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al guardar los datos: " + ex.Message);
        }
    }

}



