namespace Façade
{
    public class ComponenteGestionDocumento : IGestionDocumento
    {

        public string Documento(int indice)
        {
            return "Documento número " + indice;
        }
    }
}
