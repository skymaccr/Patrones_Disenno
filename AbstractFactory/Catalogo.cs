using AbstractFactory;
using System;

public class Catalogo
{
    public static int nAutos = 3;
    public static int nScooters = 2;
    public static int nAviones = 2;

    static void Main(string[] args)
    {
        FabricaVehiculo fabrica;
        Automovil[] autos = new Automovil[nAutos];
        Scooter[] scooters = new Scooter[nScooters];
        Avion[] aviones = new Avion[nAviones];

        Console.WriteLine("Desea utilizar " +
          "veh�culos el�ctricos (1) o a gasolina (2):");
        string eleccion = Console.ReadLine();
        if (eleccion == "1")
        {
            fabrica = new FabricaVehiculoElectricidad();
        }
        else
        {
            fabrica = new FabricaVehiculoGasolina();
        }

        for (int index = 0; index < nAutos; index++)
            autos[index] = fabrica.creaAutomovil("est�ndar", "amarillo", 6 + index, 3.2);

        for (int index = 0; index < nScooters; index++)
            scooters[index] = fabrica.creaScooter("cl�sico", "rojo", 2 + index);

        for (int index = 0; index < nAviones; index++)
            aviones[index] = fabrica.CrearAvion("Boing", "Blanco", 8000, 10000);

        foreach (Automovil auto in autos)
            auto.mostrarCaracteristicas();

        foreach (Scooter scooter in scooters)
            scooter.mostrarCaracteristicas();

        foreach (Avion avion in aviones)
            avion.MostrarCaracteristicas();
    }

}
