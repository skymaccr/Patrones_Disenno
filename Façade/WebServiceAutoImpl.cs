using System.Collections.Generic;

namespace Façade
{
    /// <summary>
    /// Fachada
    /// Crea una interfaz con los metodos que desea exponer
    /// Invoca los componentes necesarios que exponen funcionalidad, Catalogo y Gestion de documento
    /// </summary>
    public class WebServiceAutoImpl : IWebServiceAuto
    {
        protected ICatalogo catalogo = new ComponenteCatalogo();
        protected IGestionDocumento gestionDocumento = new ComponenteGestionDocumento();

        public string Documento(int indice)
        {
            return gestionDocumento.Documento(indice);
        }

        public IList<string> BuscaVehiculos(int precioMedio, int desviacionMax)
        {
            return catalogo.BuscaVehiculos(precioMedio -
              desviacionMax, precioMedio + desviacionMax);
        }
    }
}
