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
        public void SelectionSort(int[] vetor)
        {
    
            for (int valorFixo = 0; valorFixo < vetor.Length - 1; valorFixo++)
            {
                int menor = valorFixo;

                for (int i = menor + 1; i < vetor.Length; i++)
                {

                    if (vetor[i] < vetor[menor])
                    {
                        menor = i;
                    }
                }

                if (menor != valorFixo)
                {
                    int t = vetor[valorFixo];
                    vetor[valorFixo] = vetor[menor];
                    vetor[menor] = t;
                }

            }
            //para imprimir
            for (int k = 0; k < vetor.Length; k++)
            {
                Console.WriteLine(vetor[k]);
            }
            Thread.Sleep(4000);
        }

        public void InsertionSort(int[] vetor)
        {
            var stopWatch = new Stopwatch();

            stopWatch.Start();

            int j, key, i;

            for (j = 1; j < vetor.Length; j++)
            {
                key = vetor[j];

                for (i = j - 1; (i >= 0) && (vetor[i] > key); i--)
                {
                    vetor[i + 1] = vetor[i];
                }

                vetor[i + 1] = key;
            }

            //para imprimir
            for (int k = 0; k < vetor.Length; k++)
            {
                Console.WriteLine(vetor[k]);
            }

            stopWatch.Stop();
            Console.Write("\nTempo total levado para o cálculo:  {0} milisegundos", stopWatch.ElapsedMilliseconds); //System.currentTimeMillis()
            Thread.Sleep(4000);
        }

        public void Shellsort(int[] vetor)
        {
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
                    }

                    vetor[j + h] = value;
                }
            } while (h > 1);

            //para imprimir
            for (int k = 0; k < vetor.Length; k++)
            {
                Console.WriteLine(vetor[k]);
            }
            Thread.Sleep(4000);
        }

        public void BubbleSort(int[] vetor)
        {
            throw new NotImplementedException();
        }
    }
}