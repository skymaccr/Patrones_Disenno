using AbstractFactory;
using System;

public class FabricaVehiculoGasolina : FabricaVehiculo
{
    public Automovil creaAutomovil(string modelo, string
      color, int potencia, double espacio)
    {
        return new AutomovilGasolina(modelo, color,
          potencia, espacio);
    }

    public Scooter creaScooter(string modelo, string
      color, int potencia)
    {
        return new ScooterGasolina(modelo, color, potencia);
    }

    public Avion CrearAvion(string modelo, string color, int potencia, int altitudMaxima)
    {
        return new AvionGasolina(modelo, color, potencia, altitudMaxima);
    }
}