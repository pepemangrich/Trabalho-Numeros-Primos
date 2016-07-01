using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Primos
    {
        public List<int> numeros = new List<int>();
        public int limite = 20000;

        public void iniciaLista()
        {
            for (int i = 2; i <= limite; i++)
            {
                numeros.Add(i);
            }
        }

        public void removeNaoPrimos()
        {
            for (int i = 0; i < numeros.Count; i++) 
            {
                for (int j = i + 1; j < numeros.Count; j++)
                {
                    if (numeros.ElementAt(j) % numeros.ElementAt(i) == 0)
                    {
                        numeros.RemoveAt(j);
                      
                    }
                }
                }
        }



        public void imprimeNumeros()
        {
           foreach (var n in numeros)
            {
                Console.Write(n.ToString() + "; ");
            }
            Console.WriteLine();
        }

    }
}
