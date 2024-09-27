using System;
using System.Collections.Generic;

public abstract class Documentacion
{
    protected IList<string> contenido =
        new List<string>();

    public abstract void AgregaDocumento(string documento);
    public abstract void Imprime();
}
