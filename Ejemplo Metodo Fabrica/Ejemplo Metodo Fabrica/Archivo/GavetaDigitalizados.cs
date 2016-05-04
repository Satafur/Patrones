using Ejemplo_Metodo_Fabrica.Documentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Metodo_Fabrica.Archivo
{
    public class GavetaDigitalizados : Gaveta
    {

        public GavetaDigitalizados(int noGaveta): base(noGaveta)
        {

        }

        public override IDocumento crearDocumento()
        {
            return new DocumentoPdf();
        }
    }
}
