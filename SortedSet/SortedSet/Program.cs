using System;
using System.Collections.Generic;

namespace SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conjunto de alunos:

            ISet<string> alunos = new SortedSet<string>(new ComparadorMinusculo())
            {
                "Vanessa Tonini",
                "Ana Losnak",
                "Rafael Nercessian",
                "Priscila Stuani"
            };

            alunos.Add("Rafael Rollo");
            alunos.Add("Fabio Gushiken");
            alunos.Add("Fabio Gushiken");
            alunos.Add("FABIO GUSHIKEN");

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            ISet<string> outroConjunto = new HashSet<string>()
            {
                "Rafael Rollo",
                "Fabio Gushiken"
            };

            // Este conjunto é subconjunto do outro? IsSubsetOf

            bool isSubsetOf = alunos.IsSubsetOf(outroConjunto);

            Console.WriteLine($"alunos é subconjunto de outroConjunto? {isSubsetOf}");

            // Este conjunto é superconjunto do outro? IsSupersetOf

            bool isSupersetOf = alunos.IsSupersetOf(outroConjunto);

            Console.WriteLine($"alunos é superconjunto de outroConjunto? {isSupersetOf}");

            // Os conjuntos contêm os mesmos elementos? SetEquals

            bool setEquals = alunos.SetEquals(outroConjunto);

            Console.WriteLine($"alunos e outroConjunto contêm os mesmos elementos? {setEquals}");

            // subtrai os elementos da outra coleção que também estão na atual

            alunos.ExceptWith(outroConjunto);

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            alunos.Add("Rafael Rollo");
            alunos.Add("Fabio Gushiken");

            // intersecção dos conjuntos - IntersectWith

            alunos.IntersectWith(outroConjunto);

            Console.WriteLine();

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            alunos.Clear();
            outroConjunto.Clear();

            alunos.Add("Maria");
            alunos.Add("João");
            alunos.Add("Augusto");
            outroConjunto.Add("Maria");
            outroConjunto.Add("João");
            outroConjunto.Add("Guilherme");

            // somente em um ou outro conjunto - SymmetricExceptWith

            alunos.SymmetricExceptWith(outroConjunto);

            Console.WriteLine();

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
                // Augusto e Guilherme pois Augusto está apenas em alunos
                // E Guilherme está apenas no conjunto outroConjunto
            }

            alunos.Add("Maria");
            alunos.Add("João");
            alunos.Add("Augusto");
            outroConjunto.Add("Maria");
            outroConjunto.Add("João");
            outroConjunto.Add("Guilherme");

            // união de conjuntos - UnionWith

            alunos.UnionWith(outroConjunto);

            Console.WriteLine();

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
                // Augusto, Guilherme, João e Maria
            }

            Console.ReadLine();
        }
    }
}
