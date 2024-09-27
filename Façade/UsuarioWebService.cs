using System;
using System.Collections.Generic;

namespace Façade
{
    /*
     * El objetivo del patron Façade es agrupar las interfaces de un conjunto de objetos en una interfaz unificada volviendo a este conjunto mas
     * facil de usa por parte del cliente.
     */
    public class UsuarioWebService
    {
        static void Main(string[] args)
        {
            IWebServiceAuto webServiceAuto = new WebServiceAutoImpl();
            Console.WriteLine(webServiceAuto.Documento(0));
            Console.WriteLine(webServiceAuto.Documento(1));

            IList<string> resultados = webServiceAuto.BuscaVehiculos(6000, 1000);
            if (resultados.Count > 0)
            {
                Console.WriteLine("Vehículo(s) cuyo precio está comprendido entre 5000 y 7000");
                foreach (string resultado in resultados)
                    Console.WriteLine("   " + resultado);
            }
        }
    }
}

/* USOS
-Se puede usar para dividir el sistema en subsistemas (Microservicios) API Getway
-Para tener una interfaz simple para un sistema complejo
-Para encapsular la implementacion de un sistema
 */
