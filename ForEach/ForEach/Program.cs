using System;
using System.Collections.Generic;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            var meses = new List<string>
            {
                "Janeiro", "Fevereiro", "Março",
                "Abril", "Maio", "Junho",
                "Julho", "Agosto", "Setembro",
                "Outubro", "Novembro", "Dezembro"
            };

            foreach (var mes in meses)
            {
                // A variável mes não pode ser alterada porque ela é uma variável de iteração do foreach

                //meses[0] = meses[0].ToUpper();
                // Collection was modified; enumeration operation may not execute.
                // Uma coleção não pode ser modificada dentro de um foreach
                // Caso contrário lança InvalidOperationException

                Console.WriteLine(mes);
            }

            Console.WriteLine();

            var mesesArray = new string[]
            {
                "Janeiro", "Fevereiro", "Março",
                "Abril", "Maio", "Junho",
                "Julho", "Agosto", "Setembro",
                "Outubro", "Novembro", "Dezembro"
            };

            foreach (var mes in mesesArray)
            {
                mesesArray[0] = mesesArray[0].ToUpper();
                // É possível utilizar o indexador dentro de um foreach ao trabalhar com um array
                // Pois por debaixo dos panos quando é array o foreach não trabalha com um enumerador
                // Mas sim com um laço for

                Console.WriteLine(mes);
            }

            Console.WriteLine();

            for (int i = 0; i < mesesArray.Length; i++)
            {
                Console.WriteLine(mesesArray[i]);
            }

            Console.ReadLine();
        }
    }
}
