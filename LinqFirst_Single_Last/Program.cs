using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqFirst_Single_Last
{
    class Program
    {
        static void Main(string[] args)
        {
            TestLinqMethods.TestarFirstComPredicadoEmUmaListaDeNumerosDeUmACem();

            Console.ReadKey();
            Console.Clear();
            TestLinqMethods.TestarFirstEmUmaListaComAoMenosUmaOcorrenciaDoNumeroProcurado(100);

            Console.ReadKey();
            Console.Clear();
            TestLinqMethods.TestarFirstEmUmaListaSemNenhumaOcorrenciaDoNumeroProcurado(100);

            Console.ReadKey();
            Console.Clear();
            TestLinqMethods.TestarFirstOrDefaultComAoMenosUmaOcorrenciaDoNumeroProcurado(100);

            Console.ReadKey();
            Console.Clear();
            TestLinqMethods.TestarFirstOrDefaultEmUmaListaSemNenhumaOcorrenciaDoNumeroProcurado(100);

            Console.ReadKey();
            Console.Clear();
            TestLinqMethods.TestarSingleEmUmaListaComApenasUmaOcorrenciaDoNumeroProcurado(100);

            Console.ReadKey();
            Console.Clear();
            TestLinqMethods.TestarSingleEmUmaListaSemNenhumaOcorrenciaDoNumeroProcurado(100);

            Console.ReadKey();
            Console.Clear();
            TestLinqMethods.TestarSingleEmUmaListaComMaisDeUmaOcorrenciaDoNumeroProcurado(100);
            Console.ReadKey();
        }
    }
}
