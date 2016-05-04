using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Metodo_Fabrica.Documentos
{
    class DocumentoPdf : IDocumento
    {
        private string nombre;
        private string extension;

        public DocumentoPdf()
        {
            extension = "pdf";
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string obtenerExtension()
        {
            return extension;
        }
    }
}
