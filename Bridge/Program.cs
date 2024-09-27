using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            FormularioMatriculacion formulario1 = new FormularioMatriculacionPortugal(new FormHtmlImpl());
            formulario1.Visualiza();
            if (formulario1.AdministraZona())
                formulario1.GeneraDocumento();
            Console.WriteLine();
            FormularioMatriculacion formulario2 = new FormularioMatriculacionEspaña(new FormAppletImpl());
            formulario2.Visualiza();
            if (formulario2.AdministraZona())
                formulario2.GeneraDocumento();
        }
    }
}
