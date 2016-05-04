using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Metodo_Fabrica.Documentos
{
    class DocumentoWord:IDocumento
    {
        private string nombre;
        private string extension;

        public DocumentoWord()
        {
            extension = "doc";
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
