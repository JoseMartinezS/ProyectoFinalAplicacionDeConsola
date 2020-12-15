using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalConsolaCalcularAreas
{
    class Program
    {
        static void Main(string[] args)
        {
            int b, a, area, num;
            string si;
            do
            {
                Console.WriteLine("I*************************************************I");
                Console.WriteLine("I*                                               *I");
                Console.WriteLine("I*             Elija una figura Geometrica       *I");
                Console.WriteLine("I*             1.cuadrado                        *I");
                Console.WriteLine("I*             2.rectangulo                      *I");
                Console.WriteLine("I*             3.Triangulo                       *I");
                Console.WriteLine("I*             4.romboide                        *I");
                Console.WriteLine("I*                                               *I");
                Console.WriteLine("I*************************************************I");
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("I*             Ponga la base o el lado           *I");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("I*             Ponga la altura o el lado         *I");
                a = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        area = b * a;
                        Console.WriteLine("El Area del cuadrado es :" + area);
                        break;
                    case 2:
                        area = b * a;
                        Console.WriteLine("El area del rectangulo es :" + area);
                        break;
                    case 3:
                        area = b * a / 2;
                        Console.WriteLine("El area del triangulo es :" + area);
                        break;
                    case 4:
                        area = b * a;
                        Console.WriteLine("El area del romboide es" + area);
                        break;
                }
                Console.WriteLine("I*             Desea volver a intentarlo         *I");
                si = Console.ReadLine();
            }
            while (si == "SI" || si == "si");
            
        }
    }
}
