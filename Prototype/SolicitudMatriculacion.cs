using System;

public class SolicitudMatriculacion : Documento
{
  public override void Visualiza()
  {
    Console.WriteLine(
      "Muestra la solicitud de matriculaci�n: " + contenido);
  }

  public override void Imprime()
  {
    Console.WriteLine(
      "Imprime la solicitud de matriculaci�n: " + contenido);
  }
}
