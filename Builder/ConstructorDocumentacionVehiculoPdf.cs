using System;

public class ConstructorDocumentacionVehiculoPdf :
  ConstructorDocumentacionVehiculo
{
    public ConstructorDocumentacionVehiculoPdf()
    {
        documentacion = new DocumentacionPdf();
    }

    public override void ConstruyeSolicitudPedido(string
      nombreCliente)
    {
        string documento;
        documento = "<PDF>Solicitud de pedido Cliente: " +
          nombreCliente + "</PDF>";
        documentacion.AgregaDocumento(documento);
    }

    public override void ConstruyeSolicitudMatriculacion
      (string nombreSolicitante)
    {
        string documento;
        documento =
        "<PDF>Solicitud de matriculaci�n Solicitante: " +
        nombreSolicitante + "</PDF>";
        documentacion.AgregaDocumento(documento);
    }
}
