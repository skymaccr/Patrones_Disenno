using System;

public class CertificadoCesion : Documento
{
  public override void Visualiza()
  {
    Console.WriteLine(
      "Muestra el certificado de cesi�n: " + contenido);
  }

  public override void Imprime()
  {
    Console.WriteLine(
      "Imprime el certificado de cesi�n: " + contenido);
  }
}
