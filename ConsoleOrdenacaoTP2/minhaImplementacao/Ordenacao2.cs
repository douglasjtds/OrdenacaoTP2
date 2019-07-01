using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleOrdenacaoTP2.minhaImplementacao
{
    public class Ordenacao2 : IOrdenacao2
    {
        public static long numeroDeComparacoes;
        public static long numeroDeAtribuicoes;

        public void SelectionSort(int[] vetor)
        {
            numeroDeComparacoes = 0;
            numeroDeAtribuicoes = 0;

            var stopWatch = new Stopwatch();
            stopWatch.Start();

            for (int valorFixo = 0; valorFixo < vetor.Length - 1; valorFixo++)
            {
                int menor = valorFixo;

                for (int i = menor + 1; i < vetor.Length; i++)
                {

                    if (vetor[i] < vetor[menor])
                    {
                        menor = i;
                        numeroDeComparacoes++;
                    }
                }

                if (menor != valorFixo)
                {
                    int t = vetor[valorFixo];
                    vetor[valorFixo] = vetor[menor];
                    vetor[menor] = t;
                    numeroDeAtribuicoes++;
                }

            }
            //para imprimir
            for (int k = 0; k < vetor.Length; k++)
            {
                Console.WriteLine("\t" + vetor[k]);
            }

            stopWatch.Stop();
            Console.ReadKey();
            Console.Write("\nTempo total levado para o cálculo:  {0} milisegundos", stopWatch.ElapsedMilliseconds); //System.currentTimeMillis()
            Console.Write("\nO número de comparações é: {0}", numeroDeComparacoes);
            Console.Write("\nO número de atribuições é: {0}", numeroDeAtribuicoes);
            Console.ReadKey();
            //Thread.Sleep(4000);
        }

        public void InsertionSort(int[] vetor)
        {
            numeroDeComparacoes = 0;
            numeroDeAtribuicoes = 0;

            var stopWatch = new Stopwatch();
            stopWatch.Start();

            int j, key, i;

            for (j = 1; j < vetor.Length; j++)
            {
                key = vetor[j];

                for (i = j - 1; (i >= 0) && (vetor[i] > key); i--)
                {
                    vetor[i + 1] = vetor[i];
                    numeroDeComparacoes++;
                }

                vetor[i + 1] = key;
                numeroDeAtribuicoes++;
            }

            //para imprimir
            Console.WriteLine("\nO vetor ordenado é o seguinte: ");
            for (int k = 0; k < vetor.Length; k++)
            {
                Console.WriteLine("\t" + vetor[k]);
            }

            stopWatch.Stop();
            Console.ReadKey();
            Console.Write("\nTempo total levado para o cálculo:  {0} milisegundos", stopWatch.ElapsedMilliseconds); //System.currentTimeMillis()
            Console.Write("\nO número de comparações é: {0}", numeroDeComparacoes);
            Console.Write("\nO número de atribuições é: {0}", numeroDeAtribuicoes);
            Console.ReadKey();
            //Thread.Sleep(4000);
        }

        public void Shellsort(int[] vetor)
        {
            numeroDeComparacoes = 0;
            numeroDeAtribuicoes = 0;

            var stopWatch = new Stopwatch();
            stopWatch.Start();

            int i, j, h = 1, value;

            do
            {
                h = 3 * h + 1;
            } while (h < vetor.Length);

            do
            {
                h = h / 3;

                for (i = h; i < vetor.Length; i++)
                {
                    value = vetor[i];
                    j = i - h;

                    while (j >= 0 && value < vetor[j])
                    {
                        vetor[j + h] = vetor[j];
                        j = j - h;
                        numeroDeComparacoes++;
                    }

                    vetor[j + h] = value;
                    numeroDeAtribuicoes++;
                }
            } while (h > 1);

            //para imprimir
            for (int k = 0; k < vetor.Length; k++)
            {
                Console.WriteLine("\t" + vetor[k]);
            }

            stopWatch.Stop();
            Console.ReadKey();
            Console.Write("\nTempo total levado para o cálculo:  {0} milisegundos", stopWatch.ElapsedMilliseconds); //System.currentTimeMillis()
            Console.Write("\nO número de comparações é: {0}", numeroDeComparacoes);
            Console.Write("\nO número de atribuições é: {0}", numeroDeAtribuicoes);
            Console.ReadKey();
            //Thread.Sleep(4000);
        }

        public void BubbleSort(int[] vetor)
        {
            numeroDeComparacoes = 0;
            numeroDeAtribuicoes = 0;

            var stopWatch = new Stopwatch();
            stopWatch.Start();

            int temp = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                for (int sort = 0; sort < vetor.Length - 1; sort++)
                {
                    if (vetor[sort] > vetor[sort + 1])
                    {
                        numeroDeComparacoes++;
                        temp = vetor[sort + 1];
                        vetor[sort + 1] = vetor[sort];
                        vetor[sort] = temp;
                        numeroDeAtribuicoes++;
                    }
                }
            }

            //para imprimir
            for (int k = 0; k < vetor.Length; k++)
                Console.WriteLine("\t" + vetor[k]);

            stopWatch.Stop();

            Console.ReadKey();

            Console.Write("\nTempo total levado para o cálculo:  {0} milisegundos", stopWatch.ElapsedMilliseconds); //System.currentTimeMillis()
            Console.Write("\nO número de comparações é: {0}", numeroDeComparacoes);
            Console.Write("\nO número de atribuições é: {0}", numeroDeAtribuicoes);
            //Thread.Sleep(4000);
            Console.ReadKey();
        }
    }
}