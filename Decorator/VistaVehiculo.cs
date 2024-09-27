using System;

namespace Decorator
{
    public class VistaVehiculo : IComponenteGraficoVehiculo
    {
        public void Visualiza()
        {
            Console.WriteLine("Visualización del vehículo");
        }
    }
}
