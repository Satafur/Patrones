using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejemplo_Metodo_Fabrica.Documentos;

namespace Ejemplo_Metodo_Fabrica.Archivo
{
    public class GavetaOficios : Gaveta
    {

        public GavetaOficios(int noGaveta): base(noGaveta)
        {
            
        }

        public override IDocumento crearDocumento()
        {
            return new DocumentoWord();
        }
    }
}
