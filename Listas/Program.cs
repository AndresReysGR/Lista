using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> colors =
                new List<string>();
            colors.Add("\nazul");
            colors.Add("\nAmarillo");
            colors.Add("\nnaranja");
            colors.Add("\nrojo");
            //para borrar
            colors.RemoveAt(1);
            colors.Remove("Amarillo");
                  //añadir
            Console.WriteLine("\nNumero de elementos:\t" +
                colors.Count);
            //mucho datos
            /* Console.WriteLine("Elemento 1:" +
                 colors[0]);
             Console.WriteLine("Elemento 2:" +
                 colors[1]);
             Console.WriteLine("Elemento 3:" +
                 colors[2]);
             Console.WriteLine("Elemento 4:" +
                 colors[3]);*/

            //con menos datos
            int indiceColor = 1;
            //Se puede utilzar var o string
            foreach(string /*var*/ color in colors)
            {
                //Añadir elemenotos en lista
                Console.WriteLine("\nElemento" + indiceColor.ToString()+ ": " + color);
                indiceColor++;

            }

            Console.Read();
        }
    }
}
