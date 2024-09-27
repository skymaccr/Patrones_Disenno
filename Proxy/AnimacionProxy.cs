using System;

namespace Proxy
{
    /*
     * Proxy: recibe las llamadas del cliente en lugar del sujeto real. Cuando lo juzga apropiado, delega estos mensajes al sujeto real.
     */
    public class AnimacionProxy : IAnimacion
    {
        protected Video video = null;
        protected string foto = "Mostrar la foto";

        public void Click()
        {
            if(video == null)
            {
                video = new Video();
                video.Carga();
                video.Reproduce();
            }
        }

        public void Dibuja()
        {
            if (video != null)
            { 
                video.Dibuja();
            }
            else
            {
                Dibuja(foto);
            }
        }

        public void Dibuja(string foto)
        {
            Console.WriteLine(foto);
        }
    }
}
