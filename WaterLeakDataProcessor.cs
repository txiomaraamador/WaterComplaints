using System;
using Newtonsoft.Json;
using System.IO;

public class WaterLeakDataProcessor
{
    public void ProcessData(WaterLeakReport data)
    {
        string jsonData = JsonConvert.SerializeObject(data, Formatting.Indented);

        // Generar un nuevo ID único para el registro
        string folio = Guid.NewGuid().ToString();

        // Agregar el ID al objeto JSON
        jsonData = jsonData.Insert(1, $@"""id"": ""{folio}"", ");

        Console.WriteLine("Datos en formato JSON:");
        Console.WriteLine(jsonData);

        GuardarJson(jsonData);
    }

    private void GuardarJson(string jsonData)
    {
         try
        {
            // Obtener el directorio actual
            string currentDirectory = Directory.GetCurrentDirectory();

            // Crear un nuevo archivo de texto
            string filePath = Path.Combine(currentDirectory, "datos.json");

            // Leer el archivo existente, si existe
            string existingData = File.ReadAllText(filePath);

            // Verificar si el archivo ya contiene datos
            bool hasData = !string.IsNullOrEmpty(existingData);

            // Formatear el registro en formato JSON con corchetes
            string formattedData;

            if (hasData)
            {
                // Quitar el corchete de cierre del archivo existente
                existingData = existingData.TrimEnd(']');

                // Agregar una coma si ya hay datos
                formattedData = "," + jsonData;
            }
            else
            {
                // No hay datos existentes, agregar corchete de apertura
                formattedData = "[" + jsonData;
            }

            // Agregar el corchete de cierre al registro formateado
            formattedData += "\n]";

            // Guardar el JSON formateado en el archivo
            File.WriteAllText(filePath, existingData + formattedData + Environment.NewLine);

            Console.WriteLine("Los datos se han guardado correctamente en el archivo datos.json.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al guardar los datos: " + ex.Message);
        }
    }
}