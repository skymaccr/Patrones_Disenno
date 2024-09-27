namespace AbstractFactory
{
    public abstract class Avion
    {
        protected string Modelo;
        protected string Color;
        protected int Potencia;
        protected int AltitudMaxima;

        public Avion (string modelo, string color, int potencia, int altitudMaxima)
        {
            Modelo = modelo;
            Color = color;
            Potencia = potencia;
            AltitudMaxima = altitudMaxima;
        }

        public abstract void MostrarCaracteristicas();
    }
}
