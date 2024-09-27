using System.Collections.Generic;

namespace Façade
{
    public interface ICatalogo
    {
        IList<string> BuscaVehiculos(int precioMin, int precioMax);
    }
}
