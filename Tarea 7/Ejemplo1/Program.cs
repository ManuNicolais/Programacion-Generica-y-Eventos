/*Instrucciones
Identifica dentro de los códigos de los ejemplos 1 y 2 los siguientes items.
-Diseño de una clase que simula un bucle despachador de eventos.
-Definición de eventos personalizados dentro de la clase.
-Manipulación de eventos mediante suscripciones y desencadenamientos.
-Simulación de la recepción y procesamiento de mensajes utilizando eventos. */


using System;

public class Publicador
{
    // Declaración de un evento
    public event EventHandler EventoOcurrido;

    // Método que dispara el evento
    public void DispararEvento()
    {
        // Cuando ocurre el evento, se llama a todos los manejadores registrados
        EventoOcurrido?.Invoke(this, EventArgs.Empty);
    }
}

public class Suscriptor
{
    // Manejador de eventos que responde al evento
    public void ManejadorEvento(object sender, EventArgs e)
    {
        Console.WriteLine("El evento ha ocurrido.");
    }
}

class Program
{
    static void Main()
    {
        Publicador publicador = new Publicador();
        Suscriptor suscriptor = new Suscriptor();

        // Suscripción con el +=
        publicador.EventoOcurrido += suscriptor.ManejadorEvento;

        // Disparo del evento
        publicador.DispararEvento();
    }
}




using System;

// Clase que simula un bucle despachador de eventos
public class Publicador
{
    // Definimos eventos personalizados
    public event EventHandler EventoOcurrido;

    // Dispara el evento
    public void DispararEvento()
    {
        // Cuando ocurre el evento, se llama a todos los manejadores registrados
        // Manipulación de eventos mediante suscripciones y desencadenamientos
        EventoOcurrido?.Invoke(this, EventArgs.Empty);
    }
}

public class Suscriptor
{
    // Manejador de eventos que responde al evento
    public void ManejadorEvento(object sender, EventArgs e)
    {
        //Simulación de la recepción y procesamiento de mensajes utilizando eventos
        Console.WriteLine("El evento ha ocurrido.");
    }
}

class Program
{
    static void Main()
    {
        Publicador publicador = new Publicador();
        Suscriptor suscriptor = new Suscriptor();

        // Manipulación de eventos mediante suscripciones y desencadenamientos
        publicador.EventoOcurrido += suscriptor.ManejadorEvento;

        // Disparo el evento
        publicador.DispararEvento();
    }
}
