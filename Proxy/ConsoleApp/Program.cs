using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Documento oDocumento = new Documento("Mi Documento");

            try     // Necesario al usar Thread
            {
                // Pausamos la ejecución del programa durante 3 segundos
                Thread.Sleep(3000);
                // Simulamos que el usuario hace scroll
                oDocumento.hacerScroll();
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.Write("Ha ocurrido un error" + ex.Message);
            }
        }
    }
}
