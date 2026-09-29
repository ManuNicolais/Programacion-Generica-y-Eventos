using System;
using System.IO;

public class FileManager
{
    public void EscribirArchivo(string ruta, string contenido)
    {
        using (StreamWriter writer = new StreamWriter(ruta))
        {
            writer.Write(contenido);
        }
    }

    public string LeerArchivo(string ruta)
    {
        using (StreamReader reader = new StreamReader(ruta))
        {
            return reader.ReadToEnd();
        }
    }
}

class Program
{
    static void Main()
    {
        // Obtener el directorio donde se ejecuta el programa
        string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
        string filePath = Path.Combine(currentDirectory, "archivo.txt");

        FileManager fileManager = new FileManager();

        // Escribir en el archivo
        Console.WriteLine("Escribe el contenido del archivo: (Apretar 2 veces Enter para salir)");
        string contenido = string.Empty;
        string line;
        do
        {
            line = Console.ReadLine();
            if (!string.IsNullOrEmpty(line))
            {
                contenido += line + Environment.NewLine;
            }
        } while (!string.IsNullOrEmpty(line));

        fileManager.EscribirArchivo(filePath, contenido);
        Console.WriteLine("Puedes encontrar el archivo en la siguiente ruta: {0}", filePath);

        // Leer el archivo
        string contenidoLeido = fileManager.LeerArchivo(filePath);
        Console.WriteLine("Contenido del archivo:");
        Console.WriteLine(contenidoLeido);

        // Espera una entrada del usuario antes de cerrar la consola
         Console.WriteLine("Presiona cualquier tecla para salir...");
         Console.ReadKey();
    }
}
