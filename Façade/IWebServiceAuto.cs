using System.Collections.Generic;

namespace Façade
{
    public interface IWebServiceAuto
    {
        string Documento(int indice);
        IList<string> BuscaVehiculos(int precioMedio, int desviacionMax);
    }
}
