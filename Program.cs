using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1700_aprovado_reprovado_media_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informar aluno APROVADO ou REPROVADO de acordo com a média 5");
            Console.WriteLine();

            Console.Write("Nome do aluno: ");
            string n = Console.ReadLine();
            Console.WriteLine();   

            Console.Write("Nota 1: ");
            float n1 = float.Parse(Console.ReadLine()); 

            Console.Write("Nota 2: ");
            float n2 = float.Parse(Console.ReadLine());

            Console.Write("Nota 3: ");
            float n3 = float.Parse(Console.ReadLine());

            Console.Write("Nota 4: ");
            float n4 = float.Parse(Console.ReadLine());

            Console.WriteLine();

            float mf = (n1 + n2 + n3 + n4)/4;

            if (mf > 5)
            {

                Console.WriteLine("Aluno: "+n+ " | média: "+mf+" | APROVADO");

            }
            else {
                
                Console.WriteLine("Aluno: " + n + " | média: " + mf + " | REPROVADO");
            }

            Console.ReadLine();

        }
    }
}
