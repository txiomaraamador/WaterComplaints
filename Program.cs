Console.WriteLine("Bienvenido al sistema de reporte de fugas de agua");

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