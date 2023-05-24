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

        Console.WriteLine("Localización de la fuga:");
        string location = Console.ReadLine();

        Console.WriteLine("Fecha del reporte (en formato dd/mm/yyyy):");
        string userInput = Console.ReadLine();
        DateTime reportDate;
        //En esta comparación se compara la fecha itroduciada con el formato de variable "DateTime" para que lo guarde como fecha en lugar de String. 
        if (DateTime.TryParseExact(userInput, "dd/MM/yy", null, System.Globalization.DateTimeStyles.None, out reportDate))
        {
            //No se ejecuta nada en el If y continuará preguntando por datos
        }
        else
        {
            //No seguirá y termina el programa
            Console.WriteLine("Error con la fecha, favor de verificarla (El formato debe de ser dd/mm/aa)");
            return;
        }

        Console.WriteLine("Por favor ingrese el tiempo que tiene la fuga:");
        string leakTime = Console.ReadLine(); //Date Time o TimeSpan no fueron utilizados para concordar con datos menos específicos 

        Console.WriteLine("Nombre del reportador:");
        string reporterName = Console.ReadLine();

        Console.WriteLine("Descripción de la fuga:");
        string description = Console.ReadLine();

        Console.WriteLine("Localización georeferenciada:");
        string georeferencedLocation = Console.ReadLine();

        Console.WriteLine("Gravedad de la fuga (en una escala del 1 al 10):");
        int severity = int.Parse(Console.ReadLine());

        Console.WriteLine("Hora del reporte (en formato hh:mm:ss):");
        TimeSpan reportTime = TimeSpan.Parse(Console.ReadLine());

        Console.WriteLine("Número de teléfono de contacto:");
        string phoneNumber = Console.ReadLine();

        Console.WriteLine("Correo electrónico de contacto:");
        string email = Console.ReadLine();

        Console.WriteLine("Edad del reportador:");
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



