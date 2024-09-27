using System;

public class ConstructorDocumentacionVehiculoHtml :  ConstructorDocumentacionVehiculo
{
    public ConstructorDocumentacionVehiculoHtml()
    {
        documentacion = new DocumentacionHtml();
    }

    public override void ConstruyeSolicitudPedido(string
      nombreCliente)
    {
        string documento;
        documento = "<HTML>Solicitud de pedido Cliente: " +
          nombreCliente + "</HTML>";
        documentacion.AgregaDocumento(documento);
    }

    public override void ConstruyeSolicitudMatriculacion
      (string nombreSolicitante)
    {
        string documento;
        documento =
        "<HTML>Solicitud de matriculaci�n Solicitante: " +
        nombreSolicitante + "</HTML>";
        documentacion.AgregaDocumento(documento);
    }
}

