using System;
using System.Collections.Generic;
using System.Linq;

namespace OperadoresDeConjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] seq1 = { "janeiro", "fevereiro", "março" };
            string[] seq2 = { "fevereiro", "MARÇO", "abril" };

            Console.WriteLine("Concatenando duas sequências");

            IEnumerable<string> consulta = seq1.Concat(seq2); // janeiro, fevereiro, março, fevereiro, MARÇO, abril

            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine("União de duas sequências");

            IEnumerable<string> consulta2 = seq1.Union(seq2); // janeiro, fevereiro, março, MARÇO, abril

            foreach (var item in consulta2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine("União de duas sequências com comparador");

            IEnumerable<string> consulta3 = seq1.Union(seq2, StringComparer.InvariantCultureIgnoreCase);
            // janeiro, fevereiro, março, abril
            // ignora MARÇO pois março já está na união, pois ignoramos maiúsculas e minúsculas

            foreach (var item in consulta3)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine("Interseção de duas sequências");

            IEnumerable<string> consulta4 = seq1.Intersect(seq2);
            // fevereiro
            // Pois fevereiro é o único valor que está nos dois conjuntos

            foreach (var item in consulta4)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine("Exceto: elementos de seq1 que não estão em seq2");

            IEnumerable<string> consulta5 = seq1.Except(seq2);
            // janeiro, março
            // Não trás fevereiro pois fevereiro também está contido em seq2

            foreach (var item in consulta5)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
