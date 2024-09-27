using System;

namespace Proxy
{
    /*
     * Sujeto Real
     */
    public class Video : IAnimacion
    {
        public void Click()
        {
            
        }

        public void Dibuja()
        {
            Console.WriteLine("Mostrar el video");
        }

        public void Carga()
        {
            Console.WriteLine("Cargar el video");
        }

        public void Reproduce()
        {
            Console.WriteLine("Reproducir el video");
        }
    }
}
