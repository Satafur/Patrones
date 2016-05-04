using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejemplo_Metodo_Fabrica.Archivo;

namespace Ejemplo_Metodo_Fabrica
{
    class Program
    {
        static void Main(string[] args)
        {
            Archive archivo = new Archive(0);
            string extensionOficio = archivo.Gavetas[0].crearDocumento().obtenerExtension();
            string extensionPdf = archivo.Gavetas[1].crearDocumento().obtenerExtension();

            Console.WriteLine("Primera Gaveta Contiene Documentos tipo " + extensionOficio);
            Console.WriteLine("Segunda Gaveta Contiene Documentos tipo " + extensionPdf);
            Console.ReadKey();
        }
    }
}
