using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Metodo_Fabrica.Archivo
{
    public class Archive
    {
        private int noArchivador;
        private List<Gaveta> gavetas = new List<Gaveta>();

        public List<Gaveta> Gavetas
        {
            get
            {
                return gavetas;
            }
        }

        public Archive(int noArchivador)
        {
            this.noArchivador = noArchivador;
            gavetas.Add(new GavetaOficios(0));
            gavetas.Add(new GavetaDigitalizados(1));
        }
    }
}
