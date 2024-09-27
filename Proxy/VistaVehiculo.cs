using System;

/*
 * El patron Proxy tien como objetivo el diseño de un objeto que sustituye a otro objeto y que controla el acceso
 */
namespace Proxy
{
    public class VistaVehiculo
    {
        static void Main(string[] args)
        {
            IAnimacion animacion = new AnimacionProxy();
            animacion.Dibuja(); //fotografia del vehiculo
            animacion.Click();  //Se da click sobre la foto
            animacion.Dibuja(); // se carga el video
            Console.ReadLine();
        }
    }
}
/*
 Existen distintos tipos de proxy
1- Proxy virtual: Permite crear un objeto de tamaño importante en el momento adecuado
2- Proxy remoto: Permite acceder a un objeto ejecutandose en otro entorno
3- Proxy de proteccion: Permite securizar el acceso a un objeto, ejemplo mediante tecnicas de autentication
 */