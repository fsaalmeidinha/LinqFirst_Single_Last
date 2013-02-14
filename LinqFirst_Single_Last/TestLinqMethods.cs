using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqFirst_Single_Last
{
    public class TestLinqMethods
    {
        public static void TestarFirstComPredicadoEmUmaListaDeNumerosDeUmACem()
        {
            List<int> list = new List<int>(Enumerable.Range(1, 100));
            int resultado = list.First(numero => numero > 10);
            Console.WriteLine("O resultado da busca do primeiro número > 10 em uma lista de números de 1 a 100 foi {0}", resultado);
        }

        public static void TestarFirstEmUmaListaComAoMenosUmaOcorrenciaDoNumeroProcurado(int numeroProcurar)
        {
            List<int> list = new List<int>(Enumerable.Range(999, 100));
            list.Add(numeroProcurar);
            int resultado = list.First(numero => numero == numeroProcurar);
            Console.WriteLine("Nenhum erro ocorreu ao executar o método FIRST em uma lista com ao menos uma ocorrência do número sendo procurado({0}) e o resultado foi {1}", numeroProcurar, resultado);
        }

        public static void TestarFirstEmUmaListaSemNenhumaOcorrenciaDoNumeroProcurado(int numeroProcurar)
        {
            try
            {
                List<int> list = new List<int>();
                int resultado = list.First(numero => numero == numeroProcurar);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu uma exception ao executar o método FIRST em uma lista sem nenhuma ocorrência do número procurado");
            }
        }

        public static void TestarFirstOrDefaultComAoMenosUmaOcorrenciaDoNumeroProcurado(int numeroProcurar)
        {
            List<int> list = new List<int>(Enumerable.Range(999, 100));
            list.Add(numeroProcurar);
            int resultado = list.FirstOrDefault(numero => numero == numeroProcurar);
            Console.WriteLine("Nenhum erro ocorreu ao executar o método FIRST OR DEFAULT em uma lista com ao menos uma ocorrência do número procurado({0}) e o resultado foi {1}", numeroProcurar, resultado);
        }

        public static void TestarFirstOrDefaultEmUmaListaSemNenhumaOcorrenciaDoNumeroProcurado(int numeroProcurar)
        {
            List<int> list = new List<int>();
            int resultado = list.FirstOrDefault(numero => numero == numeroProcurar);
            Console.WriteLine("Nenhum erro ocorreu ao executar o método FIRST OR DEFAULT em uma lista sem nenhuma ocorrência do número procurado({0}) e o resultado foi {1}", numeroProcurar, resultado);
        }

        public static void TestarSingleEmUmaListaComApenasUmaOcorrenciaDoNumeroProcurado(int numeroProcurar)
        {
            List<int> list = new List<int>();
            list.Add(numeroProcurar);
            int resultado = list.Single(numero => numero == numeroProcurar);
            Console.WriteLine("Nenhum erro ocorreu ao executar o método SINGLE em uma lista com apenas uma ocorrência do número procurado({0}) e o resultado foi {1}", numeroProcurar, resultado);
        }

        public static void TestarSingleEmUmaListaSemNenhumaOcorrenciaDoNumeroProcurado(int numeroProcurar)
        {
            try
            {
                List<int> list = new List<int>(Enumerable.Range(numeroProcurar + 1, 100));
                list.Single(numero => numero == numeroProcurar);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu uma exception ao executar o método SINGLE em uma lista sem nenhuma ocorrência do número procurado");
            }
        }

        public static void TestarSingleEmUmaListaComMaisDeUmaOcorrenciaDoNumeroProcurado(int numeroProcurar)
        {
            try
            {
                List<int> list = new List<int>();
                list.Add(numeroProcurar);
                list.Add(numeroProcurar);
                list.Single(numero => numero == numeroProcurar);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu uma exception ao executar o método SINGLE em uma lista com mais de uma ocorrência do número procurado");
            }
        }
    }
}
