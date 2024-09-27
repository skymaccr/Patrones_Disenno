using System;

public class ClienteVehiculo
{
    static void Main(string[] args)
    {
        ConstructorDocumentacionVehiculo constructor;
        Console.WriteLine("Desea generar " +
          "documentaci�n HTML (1) o PDF (2):");
        string seleccion = Console.ReadLine();
        if (seleccion == "1")
        {
            constructor = new ConstructorDocumentacionVehiculoHtml();
        }
        else
        {
            constructor = new ConstructorDocumentacionVehiculoPdf();
        }
        Vendedor vendedor = new Vendedor(constructor);
        //un cliente pueda crear objetos complejos sin tener que preocuparse de las diferencias en su implantaci�n.
        Documentacion documentacion = vendedor.Construye("Mart�n");
        documentacion.Imprime();
    }
}
