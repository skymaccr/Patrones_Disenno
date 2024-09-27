using System;

public class DocumentacionHtml : Documentacion
{
    public override void AgregaDocumento(string documento)
    {
        if (documento.StartsWith("<HTML>"))
            contenido.Add(documento);
    }

    public override void Imprime()
    {
        Console.WriteLine("Documentaci�n HTML");
        foreach (string s in contenido)
            Console.WriteLine(s);
    }
}
