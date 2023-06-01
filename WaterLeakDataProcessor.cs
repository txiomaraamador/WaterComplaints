using System;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;

public class WaterLeakDataProcessor
{
    public void ProcessData(WaterLeakReport data)
    {
        try
        {
            string jsonData = JsonConvert.SerializeObject(data, Formatting.Indented);

            //Console.WriteLine("Datos en formato JSON:");
            //Console.WriteLine(jsonData);

            GuardarJson(jsonData);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al procesar los datos: " + ex.Message);
        }
    }

    private void GuardarJson(string jsonData)
    {
        try
        {
            // Obtener el directorio actual
            string currentDirectory = Directory.GetCurrentDirectory();

            // Crear un nuevo archivo de texto
            string filePath = Path.Combine(currentDirectory, "datos.json");

             // Leer el archivo JSON existente si existe
            List<WaterLeakReport> existingData = new List<WaterLeakReport>();
            if (File.Exists(filePath))
            {
                string existingJsonData = File.ReadAllText(filePath);
                existingData = JsonConvert.DeserializeObject<List<WaterLeakReport>>(existingJsonData);
            }

            // Agregar los nuevos datos al archivo
            WaterLeakReport newData = JsonConvert.DeserializeObject<WaterLeakReport>(jsonData);
            existingData.Add(newData);

            // Serializar y guardar los datos actualizados en el archivo JSON
            string updatedJsonData = JsonConvert.SerializeObject(existingData, Formatting.Indented);
            File.WriteAllText(filePath, updatedJsonData);

            Console.WriteLine("Los datos se han guardado correctamente en el archivo datos.json.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al guardar los datos: " + ex.Message);
        }
    }
}
