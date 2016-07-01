using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Primos p = new Primos();
            p.limite = int.Parse(Console.ReadLine());
            p.iniciaLista();
            p.removeNaoPrimos();
            p.imprimeNumeros();
            Console.ReadKey();
    
        }
    }
}
