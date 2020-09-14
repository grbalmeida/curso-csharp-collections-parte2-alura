using System;
using System.Collections.Generic;

namespace SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vamos criar um dicionário de alunos
            // VT, Vanessa, 34672
            // AL, Ana, 5617
            // RN, Rafael, 17645
            // WM, Wanderson, 11287

            IDictionary<string, Aluno> alunos =
                new Dictionary<string, Aluno>();

            alunos.Add("VT", new Aluno("Vanessa", 34672));
            alunos.Add("AL", new Aluno("Ana", 5617));
            alunos.Add("RN", new Aluno("Rafael", 17645));
            alunos.Add("WM", new Aluno("Wanderson", 11287));

            // Imprimindo...

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            // Vamos remover: AL

            alunos.Remove("AL");

            // Vamos adicionar: MO

            alunos.Add("MO", new Aluno("Marcelo", 12345));

            Console.WriteLine();

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            // Como é internamente um Dictionary?
            // Dictionary<TKey, TValue>

            // CHAVES     VALORES
            // "VT" <---> "Vanessa"
            // "AL" <---> "Ana"
            // "RN" <---> "Rafael"
            // "WM" <---> "Wanderson"

            // A ordem de um dicionário não é definida pela sequência de adições e remoções
            // Mas sim pelo seu Hash, ou código de espalhamento

            // Apresentando nova coleção ... SortedList

            IDictionary<string, Aluno> sorted
                = new SortedList<string, Aluno>();

            sorted.Add("VT", new Aluno("Vanessa", 34672));
            sorted.Add("AL", new Aluno("Ana", 5617));
            sorted.Add("RN", new Aluno("Rafael", 17645));
            sorted.Add("WM", new Aluno("Wanderson", 11287));

            Console.WriteLine();

            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }

            // Como é internamente uma SortedList?
            // SortedList<TKey, TValue>
            //
            //   |     "AL"   <---> "Ana"
            //   |     "RN"   <---> "Rafael" 
            //   |     "VT"   <---> "Vanessa"
            // \ | /   "WM"   <---> "Wanderson"
            //  \ /
            //   |     CHAVES       VALORES

            // Cada vez que inserimos um novo valor em uma SortedList ela se ordena automaticamente
            // SortedList não é um IList
            // SortedList só tem esse nome porque sua coleção de chaves é armazenada em uma lista

            Console.ReadLine();

        }
    }
}
