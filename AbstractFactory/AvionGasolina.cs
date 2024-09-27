using System;

namespace AbstractFactory
{
    public class AvionGasolina : Avion
    {
        public AvionGasolina(string modelo, string color, int potencia, int altitudMaxima) : base(modelo, color, potencia, altitudMaxima) { }

        public override void MostrarCaracteristicas()
        {
            Console.WriteLine($"Avion Gasolina modelo: {Modelo} de color: {Color} de potencia: {Potencia} Altitud maxima: {AltitudMaxima}");
        }
    }
}
