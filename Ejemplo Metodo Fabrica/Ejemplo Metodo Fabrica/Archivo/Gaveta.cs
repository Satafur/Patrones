using Ejemplo_Metodo_Fabrica.Documentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Metodo_Fabrica.Archivo
{
    public abstract class Gaveta
    {
        private int noGaveta;

        public Gaveta(int noGaveta)
        {
            this.noGaveta = noGaveta;
        }

        public abstract IDocumento crearDocumento();
    }
}
