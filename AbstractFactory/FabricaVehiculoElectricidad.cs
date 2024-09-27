using AbstractFactory;
using System;

public class FabricaVehiculoElectricidad : FabricaVehiculo
{
    public Automovil creaAutomovil(string modelo, string
      color, int potencia, double espacio)
    {
        return new AutomovilElectricidad(modelo, color,
          potencia, espacio);
    }

    public Scooter creaScooter(string modelo, string
      color, int potencia)
    {
        return new ScooterElectricidad(modelo, color,
          potencia);
    }

    public Avion CrearAvion(string modelo, string color, int potencia, int altitudMaxima)
    {
        return new AvionElectricidad(modelo, color, potencia, altitudMaxima);
    }
}
