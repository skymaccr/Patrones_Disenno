using System.Collections.Generic;

public class DocumentacionEnBlanco : Documentacion
{
    private static DocumentacionEnBlanco _instance = null;

    private DocumentacionEnBlanco()
    {
        Documentos = new List<Documento>();
    }

    public static DocumentacionEnBlanco Instance()
    {
        if (_instance == null)
            _instance = new DocumentacionEnBlanco();
        return _instance;
    }

    public void Incluye(Documento doc)
    {
        Documentos.Add(doc);
    }

    public void Excluye(Documento doc)
    {
        Documentos.Remove(doc);
    }
}
