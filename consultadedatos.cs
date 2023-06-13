using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

class Program
{
    public class Nombre()
    {
        string jsonFilePath = "datos.json";
        
        if (File.Exists(jsonFilePath))
        {
            string jsonContent = File.ReadAllText(jsonFilePath); 
            List<Datos> listaDatos = JsonConvert.DeserializeObject<List<Datos>>(jsonContent);
​
            Console.Write("Ingrese el correo: ");
            string Email = Console.ReadLine();
​
            Datos datosEncontrados = listaDatos.Find(d => d.Email== Email);  
​
            if (datosEncontrados != null) 
            {
                Console.WriteLine("Datos encontrados:");
                Console.WriteLine($"Location: {datosEncontrados.Location}");
                Console.WriteLine($"ReportDate: {datosEncontrados.ReportDate}");
                Console.WriteLine($"vanishingtime: {datosEncontrados.vanishingtime}");
                Console.WriteLine($"ReporterName: {datosEncontrados.ReporterName}");
                Console.WriteLine($"Description: {datosEncontrados.Description}");
                Console.WriteLine($"GeoreferencedLocation: {datosEncontrados.GeoreferencedLocation}");
                Console.WriteLine($"Severity: {datosEncontrados.Severity}");
                Console.WriteLine($"ReportTime: {datosEncontrados.ReportTime}");
                Console.WriteLine($"PhoneNumber: {datosEncontrados.PhoneNumber}");
                Console.WriteLine($"Email: {datosEncontrados.Email}");
                Console.WriteLine($"Age: {datosEncontrados.Age}");                

                
            }
            else 
            {
                Console.WriteLine("No se encontraron datos con el folio especificado.");
            }
        }
        else 
        {
            Console.WriteLine("El archivo JSON no existe.");
        }
    }
}