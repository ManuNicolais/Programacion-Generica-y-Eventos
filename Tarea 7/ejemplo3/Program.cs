using System.Collections.Generic;
using System;

public class Tarea
{
    public string Descripcion { get; set; }
    public bool Completada { get; set; }
}

public class ListaDeTareas
{
    public event EventHandler<string> TareaAgregada;
    public event EventHandler<string> TareaEliminada;

    private List<Tarea> tareas = new List<Tarea>();

    public void AgregarTarea(string descripcion)
    {
        var tarea = new Tarea { Descripcion = descripcion, Completada = false };
        tareas.Add(tarea);

        TareaAgregada?.Invoke(this, descripcion);
    }

    public void EliminarTarea(string descripcion)
    {
        var tarea = tareas.Find(t => t.Descripcion == descripcion);
        if (tarea != null)
        {
            tareas.Remove(tarea);
            TareaEliminada?.Invoke(this, descripcion);
        }
    }

    public void MostrarTareas()
    {
        Console.WriteLine("Lista de Tareas:");
        foreach (var tarea in tareas)
        {
            Console.WriteLine($"- [{(tarea.Completada ? "X" : " ")}] {tarea.Descripcion}");
        }
    }
}
class Program
{
    static void Main()
    {
        var listaDeTareas = new ListaDeTareas();

        listaDeTareas.TareaAgregada += (sender, descripcion) =>
        {
            Console.WriteLine($"Nueva tarea agregada: {descripcion}");
        };

        listaDeTareas.TareaEliminada += (sender, descripcion) =>
        {
            Console.WriteLine($"Tarea eliminada: {descripcion}");
        };

        listaDeTareas.AgregarTarea("Hacer compras");
        listaDeTareas.AgregarTarea("Estudiar programación");
        listaDeTareas.MostrarTareas();

        listaDeTareas.EliminarTarea("Hacer compras");
        listaDeTareas.MostrarTareas();
    }
}
