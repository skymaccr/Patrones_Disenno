using System;

namespace AbstractFactory
{
    public class AvionElectricidad : Avion
    {
        public AvionElectricidad(string modelo, string color, int potencia, int altitudMaxima) : base(modelo,color,potencia,altitudMaxima) { }

        public override void MostrarCaracteristicas()
        {
            Console.WriteLine($"Avion electrico modelo: {Modelo} de color: {Color} de potencia: {Potencia} Altitud maxima: {AltitudMaxima}");
        }
    }
}
