using System;

public interface IDocumento
{
    string Contenido { set; }
    void Dibuja();
    void Imprime();
}