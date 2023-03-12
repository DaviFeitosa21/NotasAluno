using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ex2Poo3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Aluno p1 = new Aluno();

            Console.Write("Nome do aluno: ");
            p1.nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");
            Console.Write("Nota 1: ");
            p1.n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Nota 2: ");
            p1.n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Nota 3: ");
            p1.n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("");
            Console.WriteLine("Nota final: " + p1.MediaAluno().ToString("F2", CultureInfo.InvariantCulture));

            if(p1.MediaAluno() >= 60)
            {
                Console.WriteLine("APROVADO!");
            }
            else
            {
                Console.WriteLine("REPROVADO!");
                double notaRestante = (60 - p1.MediaAluno());
                Console.WriteLine("Faltaram: " + notaRestante.ToString("F2", CultureInfo.InvariantCulture) + " Pontos ");
            }

        }
    }
}
