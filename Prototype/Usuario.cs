using System;

public class Usuario
{
    static void Main(string[] args)
    {
        DocumentacionEnBlanco documentacionEnBlanco = DocumentacionEnBlanco.Instance();
        documentacionEnBlanco.Incluye(new OrdenDePedido());
        documentacionEnBlanco.Incluye(new CertificadoCesion());
        documentacionEnBlanco.Incluye(new SolicitudMatriculacion());
        // creaci�n de documentaci�n nueva para dos clientes
        DocumentacionCliente documentacionCliente1 = new DocumentacionCliente("Mart�n");
        DocumentacionCliente documentacionCliente2 = new DocumentacionCliente("Sim�n");
        documentacionCliente1.Visualiza();
        documentacionCliente2.Visualiza();
    }
}
